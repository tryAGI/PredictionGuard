
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    /// Options to affect the output of the response.
    /// </summary>
    public sealed partial class CreateCompletionsRequestOutput
    {
        /// <summary>
        /// Set to true to turn on toxicity processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toxicity")]
        public bool? Toxicity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompletionsRequestOutput" /> class.
        /// </summary>
        /// <param name="toxicity">
        /// Set to true to turn on toxicity processing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCompletionsRequestOutput(
            bool? toxicity)
        {
            this.Toxicity = toxicity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompletionsRequestOutput" /> class.
        /// </summary>
        public CreateCompletionsRequestOutput()
        {
        }

    }
}