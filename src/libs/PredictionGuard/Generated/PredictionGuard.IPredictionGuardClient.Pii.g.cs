#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// PII<br/>
        /// Replace personal information such as names, SSNs, and emails in a given text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.PiiResponse200> PiiAsync(

            global::PredictionGuard.PiiRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// PII<br/>
        /// Replace personal information such as names, SSNs, and emails in a given text.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="replace">
        /// Whether to replace personal information.
        /// </param>
        /// <param name="replaceMethod">
        /// The method to use (random, fake, category, mask).
        /// </param>
        /// <param name="entityList">
        /// An array of entity types that the PII check should ignore.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.PiiResponse200> PiiAsync(
            global::PredictionGuard.PiiPostRequestBodyContentApplicationJsonSchemaPrompt prompt,
            bool replace,
            string? replaceMethod = default,
            global::System.Collections.Generic.IList<string>? entityList = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}