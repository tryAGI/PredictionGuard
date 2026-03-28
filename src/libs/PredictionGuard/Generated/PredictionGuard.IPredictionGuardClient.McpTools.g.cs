#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// MCP Tools<br/>
        /// Return available MCP tools by server with parameters and any relevant metadata.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.McpToolsResponse200> McpToolsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}