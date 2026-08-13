#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// Responses<br/>
        /// Generate responses while also allowing for the utilization of various tools.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.CreateResponsesResponse3> CreateResponsesAsync(

            global::PredictionGuard.CreateResponsesRequest request,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Responses<br/>
        /// Generate responses while also allowing for the utilization of various tools.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.AutoSDKHttpResponse<global::PredictionGuard.CreateResponsesResponse3>> CreateResponsesAsResponseAsync(

            global::PredictionGuard.CreateResponsesRequest request,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Responses<br/>
        /// Generate responses while also allowing for the utilization of various tools.
        /// </summary>
        /// <param name="model">
        /// The AI model to use for generating responses.
        /// </param>
        /// <param name="input"></param>
        /// <param name="instructions">
        /// A system (or developer) message inserted into the model's context.
        /// </param>
        /// <param name="maxOutputTokens">
        /// The maximum number of tokens in the generated output.
        /// </param>
        /// <param name="maxToolCalls">
        /// The maximum amount of tool calls the model is able to do.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether to enable parallel function calling during tool use.
        /// </param>
        /// <param name="reasoning">
        /// Constrains effort on reasoning for reasoning models.
        /// </param>
        /// <param name="stream">
        /// Whether to stream back the model response. Not currently supported.
        /// </param>
        /// <param name="streamOptions">
        /// Extra parameters used when streaming the response.
        /// </param>
        /// <param name="temperature">
        /// The temperature parameter for controlling randomness in completions. Supports a range of 0.0-2.0.
        /// </param>
        /// <param name="toolChoice"></param>
        /// <param name="tools">
        /// The content of the tool call.
        /// </param>
        /// <param name="topP">
        /// The diversity of the generated text based on nucleus sampling. Supports a range of 0.0-1.0.
        /// </param>
        /// <param name="safeguards">
        /// Safeguards to run on the request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.CreateResponsesResponse3> CreateResponsesAsync(
            string model,
            global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateResponsesRequestInputVariant2Item>> input,
            string? instructions = default,
            int? maxOutputTokens = default,
            int? maxToolCalls = default,
            bool? parallelToolCalls = default,
            global::PredictionGuard.CreateResponsesRequestReasoning? reasoning = default,
            bool? stream = default,
            global::PredictionGuard.CreateResponsesRequestStreamOptions? streamOptions = default,
            double? temperature = default,
            global::PredictionGuard.OneOf<string, global::PredictionGuard.CreateResponsesRequestToolChoice>? toolChoice = default,
            global::System.Collections.Generic.IList<global::PredictionGuard.CreateResponsesRequestTool>? tools = default,
            double? topP = default,
            global::PredictionGuard.CreateResponsesRequestSafeguards? safeguards = default,
            global::PredictionGuard.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}