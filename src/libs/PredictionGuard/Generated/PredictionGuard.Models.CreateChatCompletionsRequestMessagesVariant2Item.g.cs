
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChatCompletionsRequestMessagesVariant2Item
    {
        /// <summary>
        /// The role of the sender (user or assistant).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionsRequestMessagesVariant2Item" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the sender (user or assistant).
        /// </param>
        /// <param name="content"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionsRequestMessagesVariant2Item(
            string role,
            global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item>> content)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionsRequestMessagesVariant2Item" /> class.
        /// </summary>
        public CreateChatCompletionsRequestMessagesVariant2Item()
        {
        }

    }
}