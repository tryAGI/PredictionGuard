/* order: 10, title: Guardrails, slug: guardrails */

namespace PredictionGuard.IntegrationTests;

public partial class Tests
{
    //// Prediction Guard provides built-in safety guardrails alongside
    //// standard LLM capabilities. Here are examples of using the
    //// guardrail endpoints directly.

    [TestMethod]
    public async Task Guardrails_Toxicity()
    {
        using var client = GetAuthenticatedClient();

        //// Check text for toxic content:
        var response = await client.CreateToxicityAsync(
            text: "Hello, how are you today?");

        response.Should().NotBeNull();
        response.Checks.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Guardrails_Pii()
    {
        using var client = GetAuthenticatedClient();

        //// Detect and replace personally identifiable information:
        var response = await client.CreatePiiAsync(
            prompt: "My name is John Smith and my email is john@example.com",
            replace: true,
            replaceMethod: "mask");

        response.Should().NotBeNull();
        response.Checks.Should().NotBeNullOrEmpty();
    }

    [TestMethod]
    public async Task Guardrails_Injection()
    {
        using var client = GetAuthenticatedClient();

        //// Detect potential prompt injection attacks:
        var response = await client.CreateInjectionAsync(
            prompt: "What is the weather today?",
            detect: true);

        response.Should().NotBeNull();
        response.Checks.Should().NotBeNullOrEmpty();
    }
}
