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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.WhatsAppTemplateHeaderComponentParams? header = default;
            if (discriminator?.Type == global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Header)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WhatsAppTemplateHeaderComponentParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParams)}");
                header = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WhatsAppTemplateBodyComponentParams? body = default;
            if (discriminator?.Type == global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Body)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WhatsAppTemplateBodyComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WhatsAppTemplateBodyComponentParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WhatsAppTemplateBodyComponentParams)}");
                body = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WhatsAppTemplateButtonComponentParams? button = default;
            if (discriminator?.Type == global::ElevenLabs.BodySendAnOutboundMessageViaWhatsAppV1ConvaiWhatsappOutboundMessagePostTemplateParamDiscriminatorType.Button)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WhatsAppTemplateButtonComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WhatsAppTemplateButtonComponentParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WhatsAppTemplateButtonComponentParams)}");
                button = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsHeader)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WhatsAppTemplateHeaderComponentParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WhatsAppTemplateHeaderComponentParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Header!, typeInfo);
            }
            else if (value.IsBody)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WhatsAppTemplateBodyComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WhatsAppTemplateBodyComponentParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WhatsAppTemplateBodyComponentParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Body!, typeInfo);
            }
            else if (value.IsButton)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WhatsAppTemplateButtonComponentParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WhatsAppTemplateButtonComponentParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WhatsAppTemplateButtonComponentParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Button!, typeInfo);
            }
        }
    }
}