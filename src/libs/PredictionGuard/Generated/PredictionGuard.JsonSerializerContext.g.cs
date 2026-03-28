
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace PredictionGuard
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::PredictionGuard.JsonConverters.ModelsCapabilityGetParametersCapabilityJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.ModelsCapabilityGetParametersCapabilityNullableJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaInputJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItemsJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStopJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.CompletionsPostRequestBodyContentApplicationJsonSchemaPromptJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.CompletionsPostRequestBodyContentApplicationJsonSchemaStopJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItemsJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularitiesJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.InjectionPostRequestBodyContentApplicationJsonSchemaPromptJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.PiiPostRequestBodyContentApplicationJsonSchemaPromptJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1ItemsImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent), TypeInfoPropertyName = "ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaInput), TypeInfoPropertyName = "ResponsesPostRequestBodyContentApplicationJsonSchemaInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1ToolsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1ToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice), TypeInfoPropertyName = "ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItemsParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItemsHeaders))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems), TypeInfoPropertyName = "ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostResponsesContentApplicationJsonSchemaOutputItemsContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesPostResponsesContentApplicationJsonSchemaOutputItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ResponsesPostResponsesContentApplicationJsonSchemaOutputItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1ItemsImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1Items))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContent), TypeInfoPropertyName = "ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages), TypeInfoPropertyName = "ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessages2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop), TypeInfoPropertyName = "ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1Function))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice), TypeInfoPropertyName = "ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunctionParameters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItemsFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems), TypeInfoPropertyName = "ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItemsFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt), TypeInfoPropertyName = "CompletionsPostRequestBodyContentApplicationJsonSchemaPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsPostRequestBodyContentApplicationJsonSchemaLogitBias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsPostRequestBodyContentApplicationJsonSchemaStop), TypeInfoPropertyName = "CompletionsPostRequestBodyContentApplicationJsonSchemaStop2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsPostRequestBodyContentApplicationJsonSchemaStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsPostRequestBodyContentApplicationJsonSchemaOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems), TypeInfoPropertyName = "CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsPostRequestBodyContentApplicationJsonSchemaInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsPostResponsesContentApplicationJsonSchemaChoicesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CompletionsPostResponsesContentApplicationJsonSchemaChoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput), TypeInfoPropertyName = "EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.EmbeddingsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.EmbeddingsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.EmbeddingsRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities), TypeInfoPropertyName = "AudioTranscriptionsPostRequestBodyContentMultipartFormDataSchemaTimestampsGranularities2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaSegmentsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaWordsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.AudioTranscriptionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.AudioTranscriptionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.AudioTranscriptionRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.DocumentsExtractResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.DocumentsExtractRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.DocumentsExtractRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.RerankPostResponsesContentApplicationJsonSchemaResultsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.RerankResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.RerankPostResponsesContentApplicationJsonSchemaResultsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.RerankRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.RerankRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.TokenizePostResponsesContentApplicationJsonSchemaTokensItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.TokenizeResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.TokenizePostResponsesContentApplicationJsonSchemaTokensItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.TokenizeRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.TokenizeRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.DetokenizeResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.DetokenizeRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.DetokenizeRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.FactualityPostResponsesContentApplicationJsonSchemaChecksItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.FactualityResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.FactualityPostResponsesContentApplicationJsonSchemaChecksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.FactualityRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.FactualityRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.InjectionPostRequestBodyContentApplicationJsonSchemaPrompt), TypeInfoPropertyName = "InjectionPostRequestBodyContentApplicationJsonSchemaPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.InjectionPostResponsesContentApplicationJsonSchemaChecksItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.InjectionResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.InjectionPostResponsesContentApplicationJsonSchemaChecksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.InjectionRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.InjectionRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.PiiPostRequestBodyContentApplicationJsonSchemaPrompt), TypeInfoPropertyName = "PiiPostRequestBodyContentApplicationJsonSchemaPrompt2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.PiiPostResponsesContentApplicationJsonSchemaChecksItemsPiiTypeAndPositionsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.PiiPostResponsesContentApplicationJsonSchemaChecksItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.PiiPostResponsesContentApplicationJsonSchemaChecksItemsPiiTypeAndPositionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.PiiResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.PiiPostResponsesContentApplicationJsonSchemaChecksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.PiiRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.PiiRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ToxicityPostResponsesContentApplicationJsonSchemaChecksItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ToxicityResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ToxicityPostResponsesContentApplicationJsonSchemaChecksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ToxicityRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ToxicityRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ModelsCapabilityGetParametersCapability), TypeInfoPropertyName = "ModelsCapabilityGetParametersCapability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItemsCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ModelsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ModelsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ModelsRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.McpServersGetResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.McpServersResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.McpServersGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.McpServersRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.McpServersRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.McpToolsGetResponsesContentApplicationJsonSchemaDataItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.McpToolsResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::PredictionGuard.McpToolsGetResponsesContentApplicationJsonSchemaDataItems>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.McpToolsGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.McpToolsRequestBadRequestError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.McpToolsRequestForbiddenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ResponsesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ChatCompletionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CompletionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.EmbeddingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.AudioTranscriptionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.DocumentsExtractRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.RerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.TokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.DetokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.FactualityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.InjectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.PiiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.ToxicityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1ItemsContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaToolChoiceOneOf1ToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaSafeguardsEntityListItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ResponsesPostResponsesContentApplicationJsonSchemaOutputItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1ItemsContentOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaMessagesOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItemsMessageToolCallsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ChatCompletionsPostResponsesContentApplicationJsonSchemaChoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CompletionsPostRequestBodyContentApplicationJsonSchemaInputEntityListItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CompletionsPostResponsesContentApplicationJsonSchemaChoicesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputOneOf1Items>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.EmbeddingsPostResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaSegmentsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.AudioTranscriptionsPostResponsesContentApplicationJsonSchemaWordsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.RerankPostResponsesContentApplicationJsonSchemaResultsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.TokenizePostResponsesContentApplicationJsonSchemaTokensItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.FactualityPostResponsesContentApplicationJsonSchemaChecksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.InjectionPostResponsesContentApplicationJsonSchemaChecksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.PiiPostResponsesContentApplicationJsonSchemaChecksItemsPiiTypeAndPositionsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.PiiPostResponsesContentApplicationJsonSchemaChecksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ToxicityPostResponsesContentApplicationJsonSchemaChecksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ModelsCapabilityGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.McpServersGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::PredictionGuard.McpToolsGetResponsesContentApplicationJsonSchemaDataItems>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.McpToolsGetResponsesContentApplicationJsonSchemaDataItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ResponsesPostRequestBodyContentApplicationJsonSchemaToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.ChatCompletionsPostRequestBodyContentApplicationJsonSchemaToolsItems>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}