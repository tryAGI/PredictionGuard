#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// Factuality<br/>
        /// Check the factuality of a given text compared to a reference.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.FactualityResponse200> FactualityAsync(

            global::PredictionGuard.FactualityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Factuality<br/>
        /// Check the factuality of a given text compared to a reference.
        /// </summary>
        /// <param name="reference">
        /// The reference text for comparison.
        /// </param>
        /// <param name="text">
        /// The text to be checked for factuality.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.FactualityResponse200> FactualityAsync(
            string reference,
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}