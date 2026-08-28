#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class DubbingReleaseChannelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.DubbingReleaseChannel?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.DubbingReleaseChannel? Read(
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
                        return global::ElevenLabs.DubbingReleaseChannelExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.DubbingReleaseChannel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.DubbingReleaseChannel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.DubbingReleaseChannel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.DubbingReleaseChannelExtensions.ToValueString(value.Value));
            }
        }
    }
}
