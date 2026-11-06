#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateOAuth2JWTRequestJwtUsageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.UpdateOAuth2JWTRequestJwtUsage?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.UpdateOAuth2JWTRequestJwtUsage? Read(
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
                        return global::ElevenLabs.UpdateOAuth2JWTRequestJwtUsageExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.UpdateOAuth2JWTRequestJwtUsage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.UpdateOAuth2JWTRequestJwtUsage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.UpdateOAuth2JWTRequestJwtUsage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.UpdateOAuth2JWTRequestJwtUsageExtensions.ToValueString(value.Value));
            }
        }
    }
}
