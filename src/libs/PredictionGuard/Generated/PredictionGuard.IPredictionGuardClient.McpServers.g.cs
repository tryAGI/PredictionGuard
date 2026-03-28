#nullable enable

namespace PredictionGuard
{
    public partial interface IPredictionGuardClient
    {
        /// <summary>
        /// MCP Servers<br/>
        /// Return available MCP servers and tools included in those servers along with relevant metadata.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::PredictionGuard.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::PredictionGuard.McpServersResponse200> McpServersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}