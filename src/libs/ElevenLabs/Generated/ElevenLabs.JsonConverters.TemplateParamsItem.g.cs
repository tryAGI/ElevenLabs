#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class TemplateParamsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TemplateParamsItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TemplateParamsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.WhatsAppTemplateHeaderComponentParams? header = default;
            if (discriminator?.Type == global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Header)
            {
                header = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WhatsAppTemplateHeaderComponentParams>(ref reader, options);
            }
            global::ElevenLabs.WhatsAppTemplateBodyComponentParams? body = default;
            if (discriminator?.Type == global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Body)
            {
                body = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WhatsAppTemplateBodyComponentParams>(ref reader, options);
            }
            global::ElevenLabs.WhatsAppTemplateButtonComponentParams? button = default;
            if (discriminator?.Type == global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Button)
            {
                button = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WhatsAppTemplateButtonComponentParams>(ref reader, options);
            }

            var __value = new global::ElevenLabs.TemplateParamsItem(
                discriminator?.Type,
                header,

                body,

                button
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TemplateParamsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsHeader)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Header, typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParams), options);
            }
            else if (value.IsBody)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Body, typeof(global::ElevenLabs.WhatsAppTemplateBodyComponentParams), options);
            }
            else if (value.IsButton)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Button, typeof(global::ElevenLabs.WhatsAppTemplateButtonComponentParams), options);
            }
        }
    }
}