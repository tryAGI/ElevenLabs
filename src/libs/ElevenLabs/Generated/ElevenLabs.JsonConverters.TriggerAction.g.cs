#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class TriggerActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TriggerAction>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TriggerAction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.EndCallTriggerAction? endCall = default;
            if (discriminator?.Type == global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType.EndCall)
            {
                endCall = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.EndCallTriggerAction>(ref reader, options);
            }
            global::ElevenLabs.RetryTriggerAction? retry = default;
            if (discriminator?.Type == global::ElevenLabs.ContentGuardrailInputTriggerActionDiscriminatorType.Retry)
            {
                retry = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.RetryTriggerAction>(ref reader, options);
            }

            var __value = new global::ElevenLabs.TriggerAction(
                discriminator?.Type,
                endCall,

                retry
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TriggerAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEndCall)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EndCall, typeof(global::ElevenLabs.EndCallTriggerAction), options);
            }
            else if (value.IsRetry)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Retry, typeof(global::ElevenLabs.RetryTriggerAction), options);
            }
        }
    }
}