#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// Embeddings<br/>
        /// Generate vector data points from text and images.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.CreateEmbeddingsResponse3> CreateEmbeddingsAsync(

            global::PredictionGuard.CreateEmbeddingsRequest request,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embeddings<br/>
        /// Generate vector data points from text and images.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.AutoSDKHttpResponse<global::PredictionGuard.CreateEmbeddingsResponse3>> CreateEmbeddingsAsResponseAsync(

            global::PredictionGuard.CreateEmbeddingsRequest request,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embeddings<br/>
        /// Generate vector data points from text and images.
        /// </summary>
        /// <param name="model">
        /// The model to use for generating vectors.
        /// </param>
        /// <param name="input"></param>
        /// <param name="truncate">
        /// Boolean setting whether to truncate inputs. Not supported by bridgetower.
        /// </param>
        /// <param name="truncationDirection">
        /// Which direction to truncate, "Left" or "Right". Not supported by bridgetower.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.CreateEmbeddingsResponse3> CreateEmbeddingsAsync(
            string model,
            global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<global::PredictionGuard.OneOf<string, int?, global::System.Collections.Generic.IList<int>, global::PredictionGuard.CreateEmbeddingsRequestInputVariant2Item>>> input,
            bool? truncate = default,
            string? truncationDirection = default,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}