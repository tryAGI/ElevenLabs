#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ResultVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ResultVariant12>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ResultVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1Discriminator>(ref readerCopy, options);

            global::ElevenLabs.EndCallToolResultModel? endCallSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.EndCallSuccess)
            {
                endCallSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.EndCallToolResultModel>(ref reader, options);
            }
            global::ElevenLabs.LanguageDetectionToolResultModel? languageDetectionSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.LanguageDetectionSuccess)
            {
                languageDetectionSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.LanguageDetectionToolResultModel>(ref reader, options);
            }
            global::ElevenLabs.TransferToAgentToolResultSuccessModel? transferToAgentSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToAgentSuccess)
            {
                transferToAgentSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TransferToAgentToolResultSuccessModel>(ref reader, options);
            }
            global::ElevenLabs.TransferToAgentToolResultErrorModel? transferToAgentError = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToAgentError)
            {
                transferToAgentError = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TransferToAgentToolResultErrorModel>(ref reader, options);
            }
            global::ElevenLabs.TransferToNumberResultTwilioSuccessModel? transferToNumberTwilioSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberTwilioSuccess)
            {
                transferToNumberTwilioSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TransferToNumberResultTwilioSuccessModel>(ref reader, options);
            }
            global::ElevenLabs.TransferToNumberResultSipSuccessModel? transferToNumberSipSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberSipSuccess)
            {
                transferToNumberSipSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TransferToNumberResultSipSuccessModel>(ref reader, options);
            }
            global::ElevenLabs.TransferToNumberResultErrorModel? transferToNumberError = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TransferToNumberError)
            {
                transferToNumberError = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TransferToNumberResultErrorModel>(ref reader, options);
            }
            global::ElevenLabs.SkipTurnToolResponseModel? skipTurnSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.SkipTurnSuccess)
            {
                skipTurnSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SkipTurnToolResponseModel>(ref reader, options);
            }
            global::ElevenLabs.PlayDTMFResultSuccessModel? playDtmfSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.PlayDtmfSuccess)
            {
                playDtmfSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PlayDTMFResultSuccessModel>(ref reader, options);
            }
            global::ElevenLabs.PlayDTMFResultErrorModel? playDtmfError = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.PlayDtmfError)
            {
                playDtmfError = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PlayDTMFResultErrorModel>(ref reader, options);
            }
            global::ElevenLabs.VoiceMailDetectionResultSuccessModel? voicemailDetectionSuccess = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.VoicemailDetectionSuccess)
            {
                voicemailDetectionSuccess = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.VoiceMailDetectionResultSuccessModel>(ref reader, options);
            }
            global::ElevenLabs.TestToolResultModel? testingToolResult = default;
            if (discriminator?.ResultType == global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutputResultVariant1DiscriminatorResultType.TestingToolResult)
            {
                testingToolResult = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TestToolResultModel>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ResultVariant12(
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

                playDtmfError,

                voicemailDetectionSuccess,

                testingToolResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ResultVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEndCallSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCallSuccess, typeof(global::ElevenLabs.EndCallToolResultModel), options);
            }
            else if (value.IsLanguageDetectionSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LanguageDetectionSuccess, typeof(global::ElevenLabs.LanguageDetectionToolResultModel), options);
            }
            else if (value.IsTransferToAgentSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgentSuccess, typeof(global::ElevenLabs.TransferToAgentToolResultSuccessModel), options);
            }
            else if (value.IsTransferToAgentError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgentError, typeof(global::ElevenLabs.TransferToAgentToolResultErrorModel), options);
            }
            else if (value.IsTransferToNumberTwilioSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberTwilioSuccess, typeof(global::ElevenLabs.TransferToNumberResultTwilioSuccessModel), options);
            }
            else if (value.IsTransferToNumberSipSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberSipSuccess, typeof(global::ElevenLabs.TransferToNumberResultSipSuccessModel), options);
            }
            else if (value.IsTransferToNumberError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumberError, typeof(global::ElevenLabs.TransferToNumberResultErrorModel), options);
            }
            else if (value.IsSkipTurnSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkipTurnSuccess, typeof(global::ElevenLabs.SkipTurnToolResponseModel), options);
            }
            else if (value.IsPlayDtmfSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayDtmfSuccess, typeof(global::ElevenLabs.PlayDTMFResultSuccessModel), options);
            }
            else if (value.IsPlayDtmfError)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayDtmfError, typeof(global::ElevenLabs.PlayDTMFResultErrorModel), options);
            }
            else if (value.IsVoicemailDetectionSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoicemailDetectionSuccess, typeof(global::ElevenLabs.VoiceMailDetectionResultSuccessModel), options);
            }
            else if (value.IsTestingToolResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TestingToolResult, typeof(global::ElevenLabs.TestToolResultModel), options);
            }
        }
    }
}