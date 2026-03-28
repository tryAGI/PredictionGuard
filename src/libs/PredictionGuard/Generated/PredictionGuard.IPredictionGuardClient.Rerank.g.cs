#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// Rerank<br/>
        /// Rerank sorts text inputs by semantic relevance to a specified query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.RerankResponse200> RerankAsync(

            global::PredictionGuard.RerankRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerank<br/>
        /// Rerank sorts text inputs by semantic relevance to a specified query.
        /// </summary>
        /// <param name="model">
        /// The model to use for reranking.
        /// </param>
        /// <param name="query">
        /// The query to rank against.
        /// </param>
        /// <param name="documents">
        /// Array of documents to rank.
        /// </param>
        /// <param name="returnDocuments">
        /// Boolean setting whether to return documents in output.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.RerankResponse200> RerankAsync(
            string model,
            string query,
            global::System.Collections.Generic.IList<string> documents,
            bool? returnDocuments = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}