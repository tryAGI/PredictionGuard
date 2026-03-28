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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.EmbeddingsResponse200> EmbeddingsAsync(

            global::PredictionGuard.EmbeddingsRequest request,
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.EmbeddingsResponse200> EmbeddingsAsync(
            string model,
            global::PredictionGuard.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput input,
            bool? truncate = default,
            string? truncationDirection = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}