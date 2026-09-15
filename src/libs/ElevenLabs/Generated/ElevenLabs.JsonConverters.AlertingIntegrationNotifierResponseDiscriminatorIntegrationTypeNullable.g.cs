#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class AlertingIntegrationNotifierResponseDiscriminatorIntegrationTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationType?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
