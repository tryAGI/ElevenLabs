#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class AlertingIntegrationNotifierResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.AlertingIntegrationNotifierResponse>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.AlertingIntegrationNotifierResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.AlertingPagerDutyNotifierResponse? pagerduty = default;
            if (discriminator?.IntegrationType == global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationType.Pagerduty)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingPagerDutyNotifierResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingPagerDutyNotifierResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AlertingPagerDutyNotifierResponse)}");
                pagerduty = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.AlertingSlackNotifierResponse? slack = default;
            if (discriminator?.IntegrationType == global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationType.Slack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingSlackNotifierResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingSlackNotifierResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AlertingSlackNotifierResponse)}");
                slack = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.AlertingIntegrationNotifierResponse(
                discriminator?.IntegrationType,
                pagerduty,

                slack
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.AlertingIntegrationNotifierResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPagerduty)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingPagerDutyNotifierResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingPagerDutyNotifierResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AlertingPagerDutyNotifierResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pagerduty!, typeInfo);
            }
            else if (value.IsSlack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AlertingSlackNotifierResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AlertingSlackNotifierResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AlertingSlackNotifierResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Slack!, typeInfo);
            }
        }
    }
}