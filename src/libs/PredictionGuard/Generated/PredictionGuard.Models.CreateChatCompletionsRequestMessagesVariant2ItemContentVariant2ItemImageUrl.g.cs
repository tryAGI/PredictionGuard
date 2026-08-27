
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2ItemImageUrl
    {
        /// <summary>
        /// The base64 content with this prefix `data:image/jpeg;base64,`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Specifies the detail level of the image. Defaults to `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public string? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2ItemImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// The base64 content with this prefix `data:image/jpeg;base64,`
        /// </param>
        /// <param name="detail">
        /// Specifies the detail level of the image. Defaults to `auto`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2ItemImageUrl(
            string? url,
            string? detail)
        {
            this.Url = url;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2ItemImageUrl" /> class.
        /// </summary>
        public CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2ItemImageUrl()
        {
        }

    }
}