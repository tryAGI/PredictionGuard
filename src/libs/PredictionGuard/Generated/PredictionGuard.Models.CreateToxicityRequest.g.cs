
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateToxicityRequest
    {
        /// <summary>
        /// The text to check for toxicity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToxicityRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to check for toxicity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateToxicityRequest(
            string text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateToxicityRequest" /> class.
        /// </summary>
        public CreateToxicityRequest()
        {
        }

    }
}