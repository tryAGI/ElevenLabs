#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class NotifiersItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.NotifiersItem2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.NotifiersItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingSettingsResponseNotifierDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingSettingsResponseNotifierDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AlertingSettingsResponseNotifierDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.AlertingWebhookNotifierResponse? webhook = default;
            if (discriminator?.Type == global::ElevenLabs.AlertingSettingsResponseNotifierDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingWebhookNotifierResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingWebhookNotifierResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AlertingWebhookNotifierResponse)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.AlertingIntegrationNotifierResponse? integration = default;
            if (discriminator?.Type == global::ElevenLabs.AlertingSettingsResponseNotifierDiscriminatorType.Integration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingIntegrationNotifierResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingIntegrationNotifierResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AlertingIntegrationNotifierResponse)}");
                integration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.NotifiersItem2(
                discriminator?.Type,
                webhook,

                integration
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.NotifiersItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingWebhookNotifierResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingWebhookNotifierResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AlertingWebhookNotifierResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook!, typeInfo);
            }
            else if (value.IsIntegration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingIntegrationNotifierResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingIntegrationNotifierResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AlertingIntegrationNotifierResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Integration!, typeInfo);
            }
        }
    }
}