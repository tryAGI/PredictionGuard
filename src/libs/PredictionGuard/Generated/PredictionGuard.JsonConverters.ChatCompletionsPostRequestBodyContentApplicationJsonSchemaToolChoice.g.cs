#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace PredictionGuard.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice>
    {
        /// <inheritdoc />
        public override global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            var __score1 = 0;
            if (__jsonProps.Contains("function")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            string? value1 = default;
            global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1? chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1).Name}");
                        chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1).Name}");
                    chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice(
                value1,

                chatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1, typeInfo);
            }
        }
    }
}