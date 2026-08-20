#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated

# Prediction Guard publishes one OpenAPI document per API area.
spec_dir=$(mktemp -d)
trap 'rm -rf "$spec_dir"' EXIT
spec_names=(
  responses
  chat-completions
  completions
  embeddings
  audio
  documents
  rerank
  tokenization
  safety
  models
  mcp
)

for spec_name in "${spec_names[@]}"; do
  fetch_spec \
    -o "$spec_dir/$spec_name.yaml" \
    "https://raw.githubusercontent.com/predictionguard/docs-saas/main/fern/openapi/$spec_name.yaml"
done

# Fix the spec:
# 1. Merge the per-area documents and fail on conflicting paths or components.
# 2. Remove inline Authorization header parameters.
# 3. Add top-level bearer security and replace the template server URL.
ruby -ryaml - "$spec_dir" openapi.yaml <<'RUBY'
spec_dir, output = ARGV
files = Dir[File.join(spec_dir, "*.yaml")].sort
specs = files.map { |file| YAML.safe_load(File.read(file), aliases: true) }
spec = specs.shift

specs.each_with_index do |source_spec, index|
  source = files[index + 1]

  (source_spec["paths"] || {}).each do |path, value|
    raise "Conflicting path #{path} in #{source}" if spec.fetch("paths", {}).key?(path)

    (spec["paths"] ||= {})[path] = value
  end

  (source_spec["components"] || {}).each do |kind, entries|
    target = ((spec["components"] ||= {})[kind] ||= {})

    (entries || {}).each do |name, value|
      if target.key?(name) && target[name] != value
        raise "Conflicting component #{kind}/#{name} in #{source}"
      end

      target[name] ||= value
    end
  end
end

spec.fetch("paths", {}).each_value do |methods|
  %w[get post put delete patch].each do |method_name|
    operation = methods[method_name]
    next unless operation&.key?("parameters")

    operation["parameters"].reject! { |parameter| parameter["name"] == "Authorization" }
    operation.delete("parameters") if operation["parameters"].empty?
  end
end

spec["security"] = [{ "bearerAuth" => [] }]
spec["servers"] = [{ "url" => "https://api.predictionguard.com" }]

File.write(output, YAML.dump(spec).gsub(/[ \t]+$/, ""))
RUBY

autosdk generate openapi.yaml \
  --namespace PredictionGuard \
  --clientClassName PredictionGuardClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
