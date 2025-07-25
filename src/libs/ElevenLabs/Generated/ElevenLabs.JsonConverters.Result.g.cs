#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ResultJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Result>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Result Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.EndCallToolResultModel? endCallSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.EndCallSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.EndCallToolResultModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.EndCallToolResultModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.EndCallToolResultModel)}");
                endCallSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.LanguageDetectionToolResultModel? languageDetectionSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.LanguageDetectionSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.LanguageDetectionToolResultModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.LanguageDetectionToolResultModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.LanguageDetectionToolResultModel)}");
                languageDetectionSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TransferToAgentToolResultSuccessModel? transferToAgentSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToAgentSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToAgentToolResultSuccessModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TransferToAgentToolResultSuccessModel)}");
                transferToAgentSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TransferToAgentToolResultErrorModel? transferToAgentError = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToAgentError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToAgentToolResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToAgentToolResultErrorModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TransferToAgentToolResultErrorModel)}");
                transferToAgentError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? transferToNumberTwilioSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToNumberTwilioSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToNumberResultTwilioSuccessModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel)}");
                transferToNumberTwilioSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TransferToNumberResultSipSuccessModel? transferToNumberSipSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToNumberSipSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToNumberResultSipSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToNumberResultSipSuccessModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TransferToNumberResultSipSuccessModel)}");
                transferToNumberSipSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TransferToNumberResultErrorModel? transferToNumberError = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.TransferToNumberError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToNumberResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToNumberResultErrorModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TransferToNumberResultErrorModel)}");
                transferToNumberError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SkipTurnToolResponseModel? skipTurnSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.SkipTurnSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SkipTurnToolResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SkipTurnToolResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SkipTurnToolResponseModel)}");
                skipTurnSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.PlayDTMFResultSuccessModel? playDtmfSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.PlayDtmfSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PlayDTMFResultSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PlayDTMFResultSuccessModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PlayDTMFResultSuccessModel)}");
                playDtmfSuccess = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.PlayDTMFResultErrorModel? playDtmfError = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType.PlayDtmfError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PlayDTMFResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PlayDTMFResultErrorModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PlayDTMFResultErrorModel)}");
                playDtmfError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.Result(
                discriminator?.ResultType,
                endCallSuccess,
                languageDetectionSuccess,
                transferToAgentSuccess,
                transferToAgentError,
                transferToNumberTwilioSuccess,
                transferToNumberSipSuccess,
                transferToNumberError,
                skipTurnSuccess,
                playDtmfSuccess,
                playDtmfError
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Result value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEndCallSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.EndCallToolResultModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.EndCallToolResultModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.EndCallToolResultModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCallSuccess, typeInfo);
            }
            else if (value.IsLanguageDetectionSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.LanguageDetectionToolResultModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.LanguageDetectionToolResultModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.LanguageDetectionToolResultModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LanguageDetectionSuccess, typeInfo);
            }
            else if (value.IsTransferToAgentSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToAgentToolResultSuccessModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgentSuccess, typeInfo);
            }
            else if (value.IsTransferToAgentError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToAgentToolResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToAgentToolResultErrorModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TransferToAgentToolResultErrorModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgentError, typeInfo);
            }
            else if (value.IsTransferToNumberTwilioSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToNumberResultTwilioSuccessModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberTwilioSuccess, typeInfo);
            }
            else if (value.IsTransferToNumberSipSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToNumberResultSipSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToNumberResultSipSuccessModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TransferToNumberResultSipSuccessModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberSipSuccess, typeInfo);
            }
            else if (value.IsTransferToNumberError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToNumberResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToNumberResultErrorModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TransferToNumberResultErrorModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberError, typeInfo);
            }
            else if (value.IsSkipTurnSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SkipTurnToolResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SkipTurnToolResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SkipTurnToolResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkipTurnSuccess, typeInfo);
            }
            else if (value.IsPlayDtmfSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PlayDTMFResultSuccessModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PlayDTMFResultSuccessModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PlayDTMFResultSuccessModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayDtmfSuccess, typeInfo);
            }
            else if (value.IsPlayDtmfError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PlayDTMFResultErrorModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PlayDTMFResultErrorModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PlayDTMFResultErrorModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayDtmfError, typeInfo);
            }
        }
    }
}