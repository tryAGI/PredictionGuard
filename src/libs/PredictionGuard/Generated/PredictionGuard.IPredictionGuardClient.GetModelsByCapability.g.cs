#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// Models<br/>
        /// Return available models for an endpoint and relevant metadata for them.
        /// </summary>
        /// <param name="capability">
        /// Optional path variable to allow for sorting by capability. Leave blank to see all models.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.GetModelsResponse3> GetModelsByCapabilityAsync(
            global::PredictionGuard.GetModelsCapability? capability,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Models<br/>
        /// Return available models for an endpoint and relevant metadata for them.
        /// </summary>
        /// <param name="capability">
        /// Optional path variable to allow for sorting by capability. Leave blank to see all models.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.AutoSDKHttpResponse<global::PredictionGuard.GetModelsResponse3>> GetModelsByCapabilityAsResponseAsync(
            global::PredictionGuard.GetModelsCapability? capability,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}