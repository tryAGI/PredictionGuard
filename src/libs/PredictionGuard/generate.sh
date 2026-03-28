#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://docs.predictionguard.com/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://docs.predictionguard.com/openapi.json

# Fix the spec:
# 1. Remove inline Authorization header parameters (each endpoint defines auth as a parameter)
# 2. Add top-level security array referencing bearerAuth (already defined in securitySchemes)
# 3. Fix server URL (spec uses template placeholder instead of actual URL)
python3 << 'PYEOF'
import json

with open('openapi.yaml', 'r') as f:
    spec = json.load(f)

# Remove Authorization header parameters from all operations
for path, methods in spec.get('paths', {}).items():
    for method_name in ['get', 'post', 'put', 'delete', 'patch']:
        if method_name in methods:
            op = methods[method_name]
            if 'parameters' in op:
                op['parameters'] = [p for p in op['parameters'] if p.get('name') != 'Authorization']
                if not op['parameters']:
                    del op['parameters']

# Add top-level security
spec['security'] = [{'bearerAuth': []}]

# Fix server URL
spec['servers'] = [{'url': 'https://api.predictionguard.com'}]

with open('openapi.yaml', 'w') as f:
    json.dump(spec, f, indent=2)
PYEOF

autosdk generate openapi.yaml \
  --namespace PredictionGuard \
  --clientClassName PredictionGuardClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
