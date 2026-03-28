#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// Injection<br/>
        /// Injection detects potential prompt injection attacks.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.InjectionResponse200> InjectionAsync(

            global::PredictionGuard.InjectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Injection<br/>
        /// Injection detects potential prompt injection attacks.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="detect">
        /// Whether to detect potential injection attacks.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.InjectionResponse200> InjectionAsync(
            global::PredictionGuard.InjectionPostRequestBodyContentApplicationJsonSchemaPrompt prompt,
            bool detect,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}