#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Params2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Params2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Params2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SystemToolConfigOutputParamsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SystemToolConfigOutputParamsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SystemToolConfigOutputParamsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.EndCallToolConfig? endCall = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.EndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.EndCallToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.EndCallToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.EndCallToolConfig)}");
                endCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.LanguageDetectionToolConfig? languageDetection = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.LanguageDetection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.LanguageDetectionToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.LanguageDetectionToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.LanguageDetectionToolConfig)}");
                languageDetection = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TransferToAgentToolConfig? transferToAgent = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToAgentToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToAgentToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TransferToAgentToolConfig)}");
                transferToAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TransferToNumberToolConfigOutput? transferToNumber = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.TransferToNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToNumberToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToNumberToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TransferToNumberToolConfigOutput)}");
                transferToNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SkipTurnToolConfig? skipTurn = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.SkipTurn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SkipTurnToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SkipTurnToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SkipTurnToolConfig)}");
                skipTurn = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.PlayDTMFToolConfig? playKeypadTouchTone = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.PlayKeypadTouchTone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PlayDTMFToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PlayDTMFToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PlayDTMFToolConfig)}");
                playKeypadTouchTone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.VoicemailDetectionToolConfig? voicemailDetection = default;
            if (discriminator?.SystemToolType == global::ElevenLabs.SystemToolConfigOutputParamsDiscriminatorSystemToolType.VoicemailDetection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.VoicemailDetectionToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.VoicemailDetectionToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.VoicemailDetectionToolConfig)}");
                voicemailDetection = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.Params2(
                discriminator?.SystemToolType,
                endCall,
                languageDetection,
                transferToAgent,
                transferToNumber,
                skipTurn,
                playKeypadTouchTone,
                voicemailDetection
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Params2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEndCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.EndCallToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.EndCallToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.EndCallToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeInfo);
            }
            else if (value.IsLanguageDetection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.LanguageDetectionToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.LanguageDetectionToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.LanguageDetectionToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LanguageDetection, typeInfo);
            }
            else if (value.IsTransferToAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToAgentToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToAgentToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TransferToAgentToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToAgent, typeInfo);
            }
            else if (value.IsTransferToNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TransferToNumberToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TransferToNumberToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TransferToNumberToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferToNumber, typeInfo);
            }
            else if (value.IsSkipTurn)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SkipTurnToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SkipTurnToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SkipTurnToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SkipTurn, typeInfo);
            }
            else if (value.IsPlayKeypadTouchTone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PlayDTMFToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PlayDTMFToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PlayDTMFToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlayKeypadTouchTone, typeInfo);
            }
            else if (value.IsVoicemailDetection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.VoicemailDetectionToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.VoicemailDetectionToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.VoicemailDetectionToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoicemailDetection, typeInfo);
            }
        }
    }
}