#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ParametersItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ParametersItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ParametersItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.WhatsAppTemplateTextParam? text = default;
            if (discriminator?.Type == global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WhatsAppTemplateTextParam>(ref reader, options);
            }
            global::ElevenLabs.WhatsAppTemplateImageParam? image = default;
            if (discriminator?.Type == global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Image)
            {
                image = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WhatsAppTemplateImageParam>(ref reader, options);
            }
            global::ElevenLabs.WhatsAppTemplateDocumentParam? document = default;
            if (discriminator?.Type == global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Document)
            {
                document = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WhatsAppTemplateDocumentParam>(ref reader, options);
            }
            global::ElevenLabs.WhatsAppTemplateLocationParam? location = default;
            if (discriminator?.Type == global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Location)
            {
                location = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WhatsAppTemplateLocationParam>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ParametersItem(
                discriminator?.Type,
                text,

                image,

                document,

                location
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ParametersItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::ElevenLabs.WhatsAppTemplateTextParam), options);
            }
            else if (value.IsImage)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeof(global::ElevenLabs.WhatsAppTemplateImageParam), options);
            }
            else if (value.IsDocument)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeof(global::ElevenLabs.WhatsAppTemplateDocumentParam), options);
            }
            else if (value.IsLocation)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Location, typeof(global::ElevenLabs.WhatsAppTemplateLocationParam), options);
            }
        }
    }
}