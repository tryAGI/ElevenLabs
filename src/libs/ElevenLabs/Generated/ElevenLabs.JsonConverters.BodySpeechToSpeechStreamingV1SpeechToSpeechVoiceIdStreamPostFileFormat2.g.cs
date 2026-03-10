#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2 Read(
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
                        return global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2Extensions.ToValueString(value));
        }
    }
}
