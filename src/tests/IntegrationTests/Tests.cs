namespace PredictionGuard.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PredictionGuardClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PREDICTIONGUARD_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PREDICTIONGUARD_API_KEY environment variable is not found.");

        var client = new PredictionGuardClient(apiKey);
        
        return client;
    }
}
