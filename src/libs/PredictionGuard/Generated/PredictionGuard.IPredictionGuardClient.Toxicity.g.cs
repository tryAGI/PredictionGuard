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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.ToxicityResponse200> ToxicityAsync(

            global::PredictionGuard.ToxicityRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Toxicity<br/>
        /// Check the toxicity of a given text.
        /// </summary>
        /// <param name="text">
        /// The text to check for toxicity.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.ToxicityResponse200> ToxicityAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}