
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateResponsesRequestInputVariant2ItemContentVariant2Item
    {
        /// <summary>
        /// The type of content ('input_text', 'output_text', and 'input_image').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The text to provide.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The base64 content with this prefix `data:image/jpeg;base64,`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public object? ImageUrl { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateResponsesRequestInputVariant2ItemContentVariant2Item" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content ('input_text', 'output_text', and 'input_image').
        /// </param>
        /// <param name="text">
        /// The text to provide.
        /// </param>
        /// <param name="imageUrl">
        /// The base64 content with this prefix `data:image/jpeg;base64,`
        /// </param>
        /// <param name="detail">
        /// Specifies the detail level of the image. Defaults to `auto`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResponsesRequestInputVariant2ItemContentVariant2Item(
            string? type,
            string? text,
            object? imageUrl,
            string? detail)
        {
            this.Type = type;
            this.Text = text;
            this.ImageUrl = imageUrl;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResponsesRequestInputVariant2ItemContentVariant2Item" /> class.
        /// </summary>
        public CreateResponsesRequestInputVariant2ItemContentVariant2Item()
        {
        }

    }
}