
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAudioTranscriptionsResponse2
    {
        /// <summary>
        /// Description of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioTranscriptionsResponse2" /> class.
        /// </summary>
        /// <param name="error">
        /// Description of the error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAudioTranscriptionsResponse2(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAudioTranscriptionsResponse2" /> class.
        /// </summary>
        public CreateAudioTranscriptionsResponse2()
        {
        }

    }
}