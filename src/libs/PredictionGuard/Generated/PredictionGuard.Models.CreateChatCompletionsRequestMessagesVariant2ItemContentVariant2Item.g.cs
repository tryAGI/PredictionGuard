
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item
    {
        /// <summary>
        /// The type of content ('text', 'image_url').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The text to provide.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2ItemImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content ('text', 'image_url').
        /// </param>
        /// <param name="text">
        /// The text to provide.
        /// </param>
        /// <param name="imageUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item(
            string? type,
            string? text,
            global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2ItemImageUrl? imageUrl)
        {
            this.Type = type;
            this.Text = text;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item" /> class.
        /// </summary>
        public CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item()
        {
        }

    }
}