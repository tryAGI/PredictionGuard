#nullable enable

namespace PredictionGuard.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetModelsCapabilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PredictionGuard.GetModelsCapability>
    {
        /// <inheritdoc />
        public override global::PredictionGuard.GetModelsCapability Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::PredictionGuard.GetModelsCapabilityExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::PredictionGuard.GetModelsCapability)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::PredictionGuard.GetModelsCapability);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PredictionGuard.GetModelsCapability value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::PredictionGuard.GetModelsCapabilityExtensions.ToValueString(value));
        }
    }
}
