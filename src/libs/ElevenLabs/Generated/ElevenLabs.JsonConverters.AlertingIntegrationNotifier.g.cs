#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class AlertingIntegrationNotifierJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.AlertingIntegrationNotifier>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.AlertingIntegrationNotifier Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingIntegrationNotifierDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingIntegrationNotifierDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AlertingIntegrationNotifierDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.AlertingPagerDutyNotifier? pagerduty = default;
            if (discriminator?.IntegrationType == global::ElevenLabs.AlertingIntegrationNotifierDiscriminatorIntegrationType.Pagerduty)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingPagerDutyNotifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingPagerDutyNotifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AlertingPagerDutyNotifier)}");
                pagerduty = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.AlertingSlackNotifier? slack = default;
            if (discriminator?.IntegrationType == global::ElevenLabs.AlertingIntegrationNotifierDiscriminatorIntegrationType.Slack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingSlackNotifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingSlackNotifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AlertingSlackNotifier)}");
                slack = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.AlertingIntegrationNotifier(
                discriminator?.IntegrationType,
                pagerduty,

                slack
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.AlertingIntegrationNotifier value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPagerduty)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingPagerDutyNotifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingPagerDutyNotifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AlertingPagerDutyNotifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pagerduty!, typeInfo);
            }
            else if (value.IsSlack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingSlackNotifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingSlackNotifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AlertingSlackNotifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Slack!, typeInfo);
            }
        }
    }
}