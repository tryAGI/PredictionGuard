
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateChatCompletionsResponse3
    {
        /// <summary>
        /// Unique ID for the chat completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Type of object (chat completion).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Timestamp of when the chat completion was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The chat model used for generating completions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The set of result choices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsResponseChoice>? Choices { get; set; }

        /// <summary>
        /// The amount of tokens used in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::PredictionGuard.CreateChatCompletionsResponseUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionsResponse3" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID for the chat completion.
        /// </param>
        /// <param name="object">
        /// Type of object (chat completion).
        /// </param>
        /// <param name="created">
        /// Timestamp of when the chat completion was created.
        /// </param>
        /// <param name="model">
        /// The chat model used for generating completions.
        /// </param>
        /// <param name="choices">
        /// The set of result choices.
        /// </param>
        /// <param name="usage">
        /// The amount of tokens used in the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionsResponse3(
            string? id,
            string? @object,
            int? created,
            string? model,
            global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsResponseChoice>? choices,
            global::PredictionGuard.CreateChatCompletionsResponseUsage? usage)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Choices = choices;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionsResponse3" /> class.
        /// </summary>
        public CreateChatCompletionsResponse3()
        {
        }

    }
}