#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat Read(
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
                        return global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormatExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormatExtensions.ToValueString(value));
        }
    }
}
