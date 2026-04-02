#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class CustomSipHeadersItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.CustomSipHeadersItem2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.CustomSipHeadersItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.CustomSIPHeader? dynamic1 = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType.Dynamic)
            {
                dynamic1 = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CustomSIPHeader>(ref reader, options);
            }
            global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? dynamic2 = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowPhoneNumberNodeModelInputCustomSipHeaderDiscriminatorType.Dynamic)
            {
                dynamic2 = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CustomSIPHeaderWithDynamicVariable>(ref reader, options);
            }

            var __value = new global::ElevenLabs.CustomSipHeadersItem2(
                discriminator?.Type,
                dynamic1,

                dynamic2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.CustomSipHeadersItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsDynamic1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic1, typeof(global::ElevenLabs.CustomSIPHeader), options);
            }
            else if (value.IsDynamic2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dynamic2, typeof(global::ElevenLabs.CustomSIPHeaderWithDynamicVariable), options);
            }
        }
    }
}