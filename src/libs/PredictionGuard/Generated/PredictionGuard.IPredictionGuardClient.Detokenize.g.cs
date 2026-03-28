#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// Detokenize<br/>
        /// Generates text from tokens using a model's tokenizer.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.DetokenizeResponse200> DetokenizeAsync(

            global::PredictionGuard.DetokenizeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detokenize<br/>
        /// Generates text from tokens using a model's tokenizer.
        /// </summary>
        /// <param name="model">
        /// The name of the model to use for detokenization.
        /// </param>
        /// <param name="tokens">
        /// The tokens to turn into text.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.DetokenizeResponse200> DetokenizeAsync(
            string model,
            global::System.Collections.Generic.IList<int> tokens,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}