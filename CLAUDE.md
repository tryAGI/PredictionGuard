# CLAUDE.md -- PredictionGuard SDK

## Overview

Auto-generated C# SDK for [Prediction Guard](https://predictionguard.com/) -- LLM platform with built-in safety guardrails including factuality checking, toxicity detection, PII detection/replacement, and prompt injection detection.
OpenAPI spec from the official [docs.predictionguard.com](https://docs.predictionguard.com/openapi.json).

## Build & Test

```bash
dotnet build PredictionGuard.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new PredictionGuardClient(apiKey); // PREDICTIONGUARD_API_KEY env var
```

## Key Files

- `src/libs/PredictionGuard/openapi.yaml` -- OpenAPI spec (downloaded from docs.predictionguard.com)
- `src/libs/PredictionGuard/generate.sh` -- Downloads spec, fixes auth/server URL via Python, runs autosdk
- `src/libs/PredictionGuard/Generated/` -- **Never edit** -- auto-generated code (~335 files)
- `src/libs/PredictionGuard/Extensions/PredictionGuardClient.Tools.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- Spec uses inline `Authorization` header parameters on each endpoint instead of proper `security`
- `generate.sh` removes those parameters and adds top-level `security: [bearerAuth]` (securitySchemes already defined in spec)
- Spec server URL is a template placeholder (`{your-pg.api-domain}.com`), fixed to `https://api.predictionguard.com`

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/responses` | POST | Responses API (OpenAI-compatible) |
| `/chat/completions` | POST | Chat completions with guardrails |
| `/completions` | POST | Text completions |
| `/embeddings` | POST | Text embeddings |
| `/audio/transcriptions` | POST | Audio transcription |
| `/documents/extract` | POST | Document extraction |
| `/rerank` | POST | Rerank results |
| `/tokenize` | POST | Tokenize text |
| `/detokenize` | POST | Detokenize tokens |
| `/factuality` | POST | Check text factuality |
| `/injection` | POST | Detect prompt injection |
| `/PII` | POST | Detect/replace PII |
| `/toxicity` | POST | Check text toxicity |
| `/models/{capability}` | GET | List available models |
| `/mcp_servers` | GET | List MCP servers |
| `/mcp_tools` | GET | List MCP tools |

## MEAI

AIFunction tools for guardrail endpoints (for use with any `IChatClient`):
- `AsFactualityCheckTool()` -- Check text factuality against a reference
- `AsToxicityCheckTool()` -- Check text for toxic content
- `AsPiiDetectionTool()` -- Detect and replace PII in text
- `AsInjectionDetectionTool()` -- Detect prompt injection attacks
