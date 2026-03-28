/* order: 20, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace PredictionGuard.IntegrationTests;

public partial class Tests
{
    //// PredictionGuard provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// safety guardrail capabilities like factuality checking, toxicity
    //// detection, PII detection, and injection detection.

    [TestMethod]
    public async Task Meai_AsFactualityCheckTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for factuality checking:
        var tool = client.AsFactualityCheckTool();

        tool.Name.Should().Be("PredictionGuardFactualityCheck");
        tool.Description.Should().Contain("factuality");
    }

    [TestMethod]
    public async Task Meai_AsToxicityCheckTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for toxicity detection:
        var tool = client.AsToxicityCheckTool();

        tool.Name.Should().Be("PredictionGuardToxicityCheck");
        tool.Description.Should().Contain("toxicity");
    }

    [TestMethod]
    public async Task Meai_AsPiiDetectionTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for PII detection and replacement:
        var tool = client.AsPiiDetectionTool();

        tool.Name.Should().Be("PredictionGuardPiiDetection");
        tool.Description.Should().Contain("PII");
    }

    [TestMethod]
    public async Task Meai_AsInjectionDetectionTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool for prompt injection detection:
        var tool = client.AsInjectionDetectionTool();

        tool.Name.Should().Be("PredictionGuardInjectionDetection");
        tool.Description.Should().Contain("injection");
    }
}
