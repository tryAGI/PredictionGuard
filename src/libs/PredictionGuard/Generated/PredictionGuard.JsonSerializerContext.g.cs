
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
            typeof(global::PredictionGuard.JsonConverters.GetModelsCapabilityJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.GetModelsCapabilityNullableJsonConverter),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, byte[]>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2Item>>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item>>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::PredictionGuard.CreateChatCompletionsRequestToolChoice>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::PredictionGuard.OneOf<string, int?, global::System.Collections.Generic.IList<int>, global::PredictionGuard.CreateEmbeddingsRequestInputVariant2Item>>>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, int?, global::System.Collections.Generic.IList<int>, global::PredictionGuard.CreateEmbeddingsRequestInputVariant2Item>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateResponsesRequestInputVariant2Item>>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateResponsesRequestInputVariant2ItemContentVariant2Item>>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::PredictionGuard.CreateResponsesRequestToolChoice>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::PredictionGuard.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::PredictionGuard.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateAudioTranscriptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, byte[]>), TypeInfoPropertyName = "OneOfStringByteArray2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2Item>>), TypeInfoPropertyName = "OneOfStringIListCreateChatCompletionsRequestMessagesVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item>>), TypeInfoPropertyName = "OneOfStringIListCreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2ItemImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequestLogitBias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequestStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::PredictionGuard.CreateChatCompletionsRequestToolChoice>), TypeInfoPropertyName = "OneOfStringCreateChatCompletionsRequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequestToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequestToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequestTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequestToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequestOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateCompletionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateCompletionsRequestLogitBias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateCompletionsRequestStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateCompletionsRequestOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateCompletionsRequestInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateDocumentsExtractRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateEmbeddingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<global::PredictionGuard.OneOf<string, int?, global::System.Collections.Generic.IList<int>, global::PredictionGuard.CreateEmbeddingsRequestInputVariant2Item>>>), TypeInfoPropertyName = "OneOfStringIListOneOfStringInt32IListInt32CreateEmbeddingsRequestInputVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.OneOf<string, int?, global::System.Collections.Generic.IList<int>, global::PredictionGuard.CreateEmbeddingsRequestInputVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, int?, global::System.Collections.Generic.IList<int>, global::PredictionGuard.CreateEmbeddingsRequestInputVariant2Item>), TypeInfoPropertyName = "OneOfStringInt32IListInt32CreateEmbeddingsRequestInputVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateEmbeddingsRequestInputVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateRerankRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateResponsesRequestInputVariant2Item>>), TypeInfoPropertyName = "OneOfStringIListCreateResponsesRequestInputVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateResponsesRequestInputVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesRequestInputVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.IList<global::PredictionGuard.CreateResponsesRequestInputVariant2ItemContentVariant2Item>>), TypeInfoPropertyName = "OneOfStringIListCreateResponsesRequestInputVariant2ItemContentVariant2Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateResponsesRequestInputVariant2ItemContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesRequestInputVariant2ItemContentVariant2Item))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesRequestReasoning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesRequestStreamOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::PredictionGuard.CreateResponsesRequestToolChoice>), TypeInfoPropertyName = "OneOfStringCreateResponsesRequestToolChoice2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesRequestToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateResponsesRequestToolChoiceTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesRequestToolChoiceTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateResponsesRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesRequestTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesRequestSafeguards))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateInjectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreatePiiRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateToxicityRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateTokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateDetokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetModelsCapability), TypeInfoPropertyName = "GetModelsCapability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateAudioTranscriptionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateAudioTranscriptionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateAudioTranscriptionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateAudioTranscriptionsResponseSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateAudioTranscriptionsResponseSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateAudioTranscriptionsResponseWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateAudioTranscriptionsResponseWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsResponseChoiceDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsResponseChoiceMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateChatCompletionsResponseChoiceMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsResponseChoiceMessageToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsResponseChoiceMessageToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsResponseUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsResponseUsagePromptTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateChatCompletionsResponseUsageCompletionTokensDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateCompletionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateCompletionsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateCompletionsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateCompletionsResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateCompletionsResponseChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateDocumentsExtractResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateDocumentsExtractResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateDocumentsExtractResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateEmbeddingsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateEmbeddingsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateEmbeddingsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateEmbeddingsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateEmbeddingsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetMcpServersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetMcpServersResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetMcpServersResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.GetMcpServersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetMcpServersResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetMcpToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetMcpToolsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetMcpToolsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::PredictionGuard.GetMcpToolsResponseDataItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.GetMcpToolsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetMcpToolsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetModelsResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetModelsResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.GetModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetModelsResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.GetModelsResponseDataItemCapabilities))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateRerankResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateRerankResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateRerankResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateRerankResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateRerankResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateResponsesResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesResponseOutputItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateResponsesResponseOutputItemContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateInjectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateInjectionResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateInjectionResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateInjectionResponseCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateInjectionResponseCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreatePiiResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreatePiiResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreatePiiResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreatePiiResponseCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreatePiiResponseCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreatePiiResponseCheckPiiTypeAndPosition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreatePiiResponseCheckPiiTypeAndPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateToxicityResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateToxicityResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateToxicityResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateToxicityResponseCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateToxicityResponseCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateTokenizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateTokenizeResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateTokenizeResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::PredictionGuard.CreateTokenizeResponseToken>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateTokenizeResponseToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateDetokenizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateDetokenizeResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.CreateDetokenizeResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.List<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.List<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateChatCompletionsRequestMessagesVariant2ItemContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateChatCompletionsRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.List<global::PredictionGuard.OneOf<string, int?, global::System.Collections.Generic.List<int>, global::PredictionGuard.CreateEmbeddingsRequestInputVariant2Item>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.OneOf<string, int?, global::System.Collections.Generic.List<int>, global::PredictionGuard.CreateEmbeddingsRequestInputVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, int?, global::System.Collections.Generic.List<int>, global::PredictionGuard.CreateEmbeddingsRequestInputVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.List<global::PredictionGuard.CreateResponsesRequestInputVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateResponsesRequestInputVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::PredictionGuard.OneOf<string, global::System.Collections.Generic.List<global::PredictionGuard.CreateResponsesRequestInputVariant2ItemContentVariant2Item>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateResponsesRequestInputVariant2ItemContentVariant2Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateResponsesRequestToolChoiceTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateResponsesRequestTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateAudioTranscriptionsResponseSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateAudioTranscriptionsResponseWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateChatCompletionsResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateChatCompletionsResponseChoiceMessageToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateCompletionsResponseChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateEmbeddingsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.GetMcpServersResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::PredictionGuard.GetMcpToolsResponseDataItem>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.GetMcpToolsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.GetModelsResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateRerankResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateResponsesResponseOutputItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateInjectionResponseCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreatePiiResponseCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreatePiiResponseCheckPiiTypeAndPosition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateToxicityResponseCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::PredictionGuard.CreateTokenizeResponseToken>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}