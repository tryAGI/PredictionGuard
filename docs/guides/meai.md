# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The PredictionGuard SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models factuality checking, toxicity detection, PII detection, and prompt injection detection capabilities.

## Available Tools

### Factuality Check

```csharp
using Microsoft.Extensions.AI;
using PredictionGuard;

var pgClient = new PredictionGuardClient(apiKey);
var tool = pgClient.AsFactualityCheckTool();

// Use with any IChatClient:
var options = new ChatOptions
{
    Tools = [tool],
};
```

### Toxicity Check

```csharp
var tool = pgClient.AsToxicityCheckTool();
```

### PII Detection

```csharp
// Default: replace PII using mask method
var tool = pgClient.AsPiiDetectionTool();

// Custom: use fake data replacement
var tool = pgClient.AsPiiDetectionTool(replace: true, replaceMethod: "fake");
```

### Injection Detection

```csharp
var tool = pgClient.AsInjectionDetectionTool();
```

## Using Tools with an IChatClient

```csharp
using Microsoft.Extensions.AI;
using PredictionGuard;

var pgClient = new PredictionGuardClient(pgApiKey);

// Create guardrail tools
var tools = new AITool[]
{
    pgClient.AsFactualityCheckTool(),
    pgClient.AsToxicityCheckTool(),
    pgClient.AsPiiDetectionTool(),
    pgClient.AsInjectionDetectionTool(),
};

// Use with any IChatClient (e.g., OpenAI, Anthropic, Ollama)
var options = new ChatOptions { Tools = tools };
var response = await chatClient.GetResponseAsync(
    "Check if this text contains PII: My SSN is 123-45-6789",
    options);
```
