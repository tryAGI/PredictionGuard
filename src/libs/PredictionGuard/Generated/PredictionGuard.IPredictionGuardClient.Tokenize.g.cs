#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// Tokenize<br/>
        /// Generates tokens for a string using a model's tokenizer.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.TokenizeResponse200> TokenizeAsync(

            global::PredictionGuard.TokenizeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tokenize<br/>
        /// Generates tokens for a string using a model's tokenizer.
        /// </summary>
        /// <param name="model">
        /// The name of the model to use for tokenization.
        /// </param>
        /// <param name="input">
        /// The text to tokenize.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.TokenizeResponse200> TokenizeAsync(
            string model,
            string input,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}