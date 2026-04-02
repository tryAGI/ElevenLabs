#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class TriggerAction3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TriggerAction3>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TriggerAction3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.EndCallTriggerAction? endCall = default;
            if (discriminator?.Type == global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType.EndCall)
            {
                endCall = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.EndCallTriggerAction>(ref reader, options);
            }
            global::ElevenLabs.RetryTriggerAction? retry = default;
            if (discriminator?.Type == global::ElevenLabs.CustomGuardrailConfigTriggerActionDiscriminatorType.Retry)
            {
                retry = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.RetryTriggerAction>(ref reader, options);
            }

            var __value = new global::ElevenLabs.TriggerAction3(
                discriminator?.Type,
                endCall,

                retry
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TriggerAction3 value,
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