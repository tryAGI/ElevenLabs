#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Params3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Params3>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Params3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SystemToolConfigOutputParamsDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.EndCallToolConfig? endCall = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.EndCall)
            {
                endCall = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.EndCallToolConfig>(ref reader, options);
            }
            global::ElevenLabs.LanguageDetectionToolConfig? languageDetection = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.LanguageDetection)
            {
                languageDetection = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.LanguageDetectionToolConfig>(ref reader, options);
            }
            global::ElevenLabs.TransferToAgentToolConfig? transferToAgent = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToAgent)
            {
                transferToAgent = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TransferToAgentToolConfig>(ref reader, options);
            }
            global::ElevenLabs.TransferToNumberToolConfigOutput? transferToNumber = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToNumber)
            {
                transferToNumber = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TransferToNumberToolConfigOutput>(ref reader, options);
            }
            global::ElevenLabs.SkipTurnToolConfig? skipTurn = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.SkipTurn)
            {
                skipTurn = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SkipTurnToolConfig>(ref reader, options);
            }
            global::ElevenLabs.PlayDTMFToolConfig? playKeypadTouchTone = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone)
            {
                playKeypadTouchTone = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PlayDTMFToolConfig>(ref reader, options);
            }
            global::ElevenLabs.VoicemailDetectionToolConfig? voicemailDetection = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.VoicemailDetection)
            {
                voicemailDetection = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.VoicemailDetectionToolConfig>(ref reader, options);
            }

            var __value = new global::ElevenLabs.Params3(
                discriminator?.SystemToolType,
                endCall,

                languageDetection,

                transferToAgent,

                transferToNumber,

                skipTurn,

                playKeypadTouchTone,

                voicemailDetection
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Params3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEndCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeof(global::ElevenLabs.EndCallToolConfig), options);
            }
            else if (value.IsLanguageDetection)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LanguageDetection, typeof(global::ElevenLabs.LanguageDetectionToolConfig), options);
            }
            else if (value.IsTransferToAgent)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgent, typeof(global::ElevenLabs.TransferToAgentToolConfig), options);
            }
            else if (value.IsTransferToNumber)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumber, typeof(global::ElevenLabs.TransferToNumberToolConfigOutput), options);
            }
            else if (value.IsSkipTurn)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkipTurn, typeof(global::ElevenLabs.SkipTurnToolConfig), options);
            }
            else if (value.IsPlayKeypadTouchTone)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayKeypadTouchTone, typeof(global::ElevenLabs.PlayDTMFToolConfig), options);
            }
            else if (value.IsVoicemailDetection)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoicemailDetection, typeof(global::ElevenLabs.VoicemailDetectionToolConfig), options);
            }
        }
    }
}