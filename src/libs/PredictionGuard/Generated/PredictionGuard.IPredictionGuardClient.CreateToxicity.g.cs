#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// Toxicity<br/>
        /// Check the toxicity of a given text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.CreateToxicityResponse3> CreateToxicityAsync(

            global::PredictionGuard.CreateToxicityRequest request,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Toxicity<br/>
        /// Check the toxicity of a given text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.AutoSDKHttpResponse<global::PredictionGuard.CreateToxicityResponse3>> CreateToxicityAsResponseAsync(

            global::PredictionGuard.CreateToxicityRequest request,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Toxicity<br/>
        /// Check the toxicity of a given text.
        /// </summary>
        /// <param name="text">
        /// The text to check for toxicity.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.CreateToxicityResponse3> CreateToxicityAsync(
            string text,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}