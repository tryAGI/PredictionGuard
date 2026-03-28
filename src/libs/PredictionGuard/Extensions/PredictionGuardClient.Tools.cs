using Microsoft.Extensions.AI;

namespace PredictionGuard;

/// <summary>
/// Extensions for using PredictionGuardClient guardrail endpoints as MEAI tools with any IChatClient.
/// </summary>
public static class PredictionGuardToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that checks the factuality of text
    /// compared to a reference, suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Prediction Guard client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsFactualityCheckTool(this PredictionGuardClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, string reference, CancellationToken cancellationToken) =>
            {
                var response = await client.FactualityAsync(
                    reference: reference,
                    text: text,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatFactualityResponse(response);
            },
            name: "PredictionGuardFactualityCheck",
            description: "Checks the factuality of a given text by comparing it against a reference text. Returns a factuality score between 0 and 1, where higher scores indicate greater factual consistency.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that checks text for toxicity,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Prediction Guard client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsToxicityCheckTool(this PredictionGuardClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, CancellationToken cancellationToken) =>
            {
                var response = await client.ToxicityAsync(
                    text: text,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatToxicityResponse(response);
            },
            name: "PredictionGuardToxicityCheck",
            description: "Checks the toxicity of a given text. Returns a toxicity score between 0 and 1, where higher scores indicate more toxic content.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that detects and optionally replaces
    /// personally identifiable information (PII) in text, suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Prediction Guard client.</param>
    /// <param name="replace">Whether to replace detected PII (default: true).</param>
    /// <param name="replaceMethod">The replacement method: random, fake, category, or mask (default: mask).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsPiiDetectionTool(
        this PredictionGuardClient client,
        bool replace = true,
        string replaceMethod = "mask")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, CancellationToken cancellationToken) =>
            {
                var response = await client.PiiAsync(
                    prompt: text,
                    replace: replace,
                    replaceMethod: replaceMethod,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatPiiResponse(response);
            },
            name: "PredictionGuardPiiDetection",
            description: "Detects and optionally replaces personally identifiable information (PII) such as names, SSNs, emails, and phone numbers in the given text. Returns the sanitized text and details about detected PII entities.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that detects potential prompt injection attacks,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Prediction Guard client.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsInjectionDetectionTool(this PredictionGuardClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string text, CancellationToken cancellationToken) =>
            {
                var response = await client.InjectionAsync(
                    prompt: text,
                    detect: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatInjectionResponse(response);
            },
            name: "PredictionGuardInjectionDetection",
            description: "Detects potential prompt injection attacks in the given text. Returns a probability score between 0 and 1, where higher scores indicate a higher likelihood of prompt injection.");
    }

    private static string FormatFactualityResponse(FactualityResponse200 response)
    {
        var parts = new List<string> { "Factuality Check:" };

        if (response.Checks is { Count: > 0 })
        {
            foreach (var check in response.Checks)
            {
                parts.Add($"- Score: {check.Score:F4} (0 = not factual, 1 = fully factual)");
            }
        }
        else
        {
            parts.Add("- No factuality results returned.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatToxicityResponse(ToxicityResponse200 response)
    {
        var parts = new List<string> { "Toxicity Check:" };

        if (response.Checks is { Count: > 0 })
        {
            foreach (var check in response.Checks)
            {
                parts.Add($"- Score: {check.Score:F4} (0 = not toxic, 1 = highly toxic)");
            }
        }
        else
        {
            parts.Add("- No toxicity results returned.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatPiiResponse(PiiResponse200 response)
    {
        var parts = new List<string> { "PII Detection:" };

        if (response.Checks is { Count: > 0 })
        {
            foreach (var check in response.Checks)
            {
                if (check.PiiTypeAndPositions is { Count: > 0 })
                {
                    parts.Add($"- PII found ({check.PiiTypeAndPositions.Count} entities detected):");
                    foreach (var pii in check.PiiTypeAndPositions)
                    {
                        parts.Add($"  - Type: {pii.Type}, Position: {pii.Start}-{pii.End}");
                    }

                    if (!string.IsNullOrWhiteSpace(check.NewPrompt))
                    {
                        parts.Add($"- Sanitized text: {check.NewPrompt}");
                    }
                }
                else
                {
                    parts.Add("- No PII detected in the text.");
                    if (!string.IsNullOrWhiteSpace(check.Prompt))
                    {
                        parts.Add($"- Original text: {check.Prompt}");
                    }
                }
            }
        }
        else
        {
            parts.Add("- No PII results returned.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatInjectionResponse(InjectionResponse200 response)
    {
        var parts = new List<string> { "Injection Detection:" };

        if (response.Checks is { Count: > 0 })
        {
            foreach (var check in response.Checks)
            {
                parts.Add($"- Probability: {check.Probability:F4} (0 = safe, 1 = likely injection)");
                parts.Add($"- Status: {check.Status}");
            }
        }
        else
        {
            parts.Add("- No injection detection results returned.");
        }

        return string.Join("\n", parts);
    }
}
