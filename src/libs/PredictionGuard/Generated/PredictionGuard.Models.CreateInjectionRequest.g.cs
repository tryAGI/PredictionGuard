
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateInjectionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<string>> Prompt { get; set; }

        /// <summary>
        /// Whether to detect potential injection attacks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detect")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Detect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInjectionRequest" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="detect">
        /// Whether to detect potential injection attacks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateInjectionRequest(
            global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<string>> prompt,
            bool detect)
        {
            this.Prompt = prompt;
            this.Detect = detect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInjectionRequest" /> class.
        /// </summary>
        public CreateInjectionRequest()
        {
        }

    }
}