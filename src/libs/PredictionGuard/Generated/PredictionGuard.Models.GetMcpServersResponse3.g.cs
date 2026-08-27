
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetMcpServersResponse3
    {
        /// <summary>
        /// Type of object (list).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The available MCP servers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::PredictionGuard.GetMcpServersResponseDataItem>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpServersResponse3" /> class.
        /// </summary>
        /// <param name="object">
        /// Type of object (list).
        /// </param>
        /// <param name="data">
        /// The available MCP servers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetMcpServersResponse3(
            string? @object,
            global::System.Collections.Generic.IList<global::PredictionGuard.GetMcpServersResponseDataItem>? data)
        {
            this.Object = @object;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpServersResponse3" /> class.
        /// </summary>
        public GetMcpServersResponse3()
        {
        }

    }
}