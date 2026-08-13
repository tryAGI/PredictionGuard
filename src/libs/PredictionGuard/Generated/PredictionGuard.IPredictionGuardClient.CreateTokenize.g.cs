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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.CreateTokenizeResponse3> CreateTokenizeAsync(

            global::PredictionGuard.CreateTokenizeRequest request,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tokenize<br/>
        /// Generates tokens for a string using a model's tokenizer.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.AutoSDKHttpResponse<global::PredictionGuard.CreateTokenizeResponse3>> CreateTokenizeAsResponseAsync(

            global::PredictionGuard.CreateTokenizeRequest request,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.CreateTokenizeResponse3> CreateTokenizeAsync(
            string model,
            string input,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}