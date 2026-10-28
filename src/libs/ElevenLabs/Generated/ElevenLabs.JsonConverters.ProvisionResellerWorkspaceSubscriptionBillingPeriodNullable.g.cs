#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProvisionResellerWorkspaceSubscriptionBillingPeriodNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriod?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriod? Read(
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
                        return global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriodExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriod?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriod? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.ProvisionResellerWorkspaceSubscriptionBillingPeriodExtensions.ToValueString(value.Value));
            }
        }
    }
}
