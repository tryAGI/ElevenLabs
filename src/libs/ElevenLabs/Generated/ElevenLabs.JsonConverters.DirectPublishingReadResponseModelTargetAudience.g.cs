#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class DirectPublishingReadResponseModelTargetAudienceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience Read(
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
                        return global::ElevenLabs.DirectPublishingReadResponseModelTargetAudienceExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.DirectPublishingReadResponseModelTargetAudience value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.DirectPublishingReadResponseModelTargetAudienceExtensions.ToValueString(value));
        }
    }
}
