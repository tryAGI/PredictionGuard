# PredictionGuard

[![Nuget package](https://img.shields.io/nuget/vpre/PredictionGuard)](https://www.nuget.org/packages/PredictionGuard/)
[![dotnet](https://github.com/tryAGI/PredictionGuard/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/PredictionGuard/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/PredictionGuard)](https://github.com/tryAGI/PredictionGuard/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official PredictionGuard OpenAPI specification](https://docs.predictionguard.com/openapi.json) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0
- Microsoft.Extensions.AI `AIFunction` tool wrappers for guardrails

### Usage
```csharp
using PredictionGuard;

using var client = new PredictionGuardClient(apiKey);
```

### Microsoft.Extensions.AI

The SDK currently exposes guardrail endpoints as `AIFunction` tools that work with any [`IChatClient`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.ai.ichatclient):

```csharp
using Microsoft.Extensions.AI;
using PredictionGuard;

var pgClient = new PredictionGuardClient(apiKey);

var tools = new AITool[]
{
    pgClient.AsFactualityCheckTool(),
    pgClient.AsToxicityCheckTool(),
    pgClient.AsPiiDetectionTool(),
    pgClient.AsInjectionDetectionTool(),
};

var options = new ChatOptions { Tools = tools };
```

See [the MEAI guide](https://tryagi.github.io/PredictionGuard/guides/meai/) for details.

<!-- EXAMPLES:START -->

<!-- EXAMPLES:END -->

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/PredictionGuard/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/PredictionGuard/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
