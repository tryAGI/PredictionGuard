
#nullable enable

namespace PredictionGuard
{
    /// <summary>
    /// Optional path variable to allow for sorting by capability. Leave blank to see all models.
    /// </summary>
    public enum GetModelsCapability
    {
        /// <summary>
        ///
        /// </summary>
        ChatCompletion,
        /// <summary>
        ///
        /// </summary>
        ChatWithImage,
        /// <summary>
        ///
        /// </summary>
        Completion,
        /// <summary>
        ///
        /// </summary>
        Detokenize,
        /// <summary>
        ///
        /// </summary>
        Embedding,
        /// <summary>
        ///
        /// </summary>
        EmbeddingWithImage,
        /// <summary>
        ///
        /// </summary>
        Reasoning,
        /// <summary>
        ///
        /// </summary>
        Rerank,
        /// <summary>
        ///
        /// </summary>
        Tokenize,
        /// <summary>
        ///
        /// </summary>
        ToolCalling,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetModelsCapabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetModelsCapability value)
        {
            return value switch
            {
                GetModelsCapability.ChatCompletion => "chat-completion",
                GetModelsCapability.ChatWithImage => "chat-with-image",
                GetModelsCapability.Completion => "completion",
                GetModelsCapability.Detokenize => "detokenize",
                GetModelsCapability.Embedding => "embedding",
                GetModelsCapability.EmbeddingWithImage => "embedding-with-image",
                GetModelsCapability.Reasoning => "reasoning",
                GetModelsCapability.Rerank => "rerank",
                GetModelsCapability.Tokenize => "tokenize",
                GetModelsCapability.ToolCalling => "tool_calling",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetModelsCapability? ToEnum(string value)
        {
            return value switch
            {
                "chat-completion" => GetModelsCapability.ChatCompletion,
                "chat-with-image" => GetModelsCapability.ChatWithImage,
                "completion" => GetModelsCapability.Completion,
                "detokenize" => GetModelsCapability.Detokenize,
                "embedding" => GetModelsCapability.Embedding,
                "embedding-with-image" => GetModelsCapability.EmbeddingWithImage,
                "reasoning" => GetModelsCapability.Reasoning,
                "rerank" => GetModelsCapability.Rerank,
                "tokenize" => GetModelsCapability.Tokenize,
                "tool_calling" => GetModelsCapability.ToolCalling,
                _ => null,
            };
        }
    }
}