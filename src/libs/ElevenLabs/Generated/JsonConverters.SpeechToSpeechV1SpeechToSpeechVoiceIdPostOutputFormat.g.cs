#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat Read(
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
                        return global::ElevenLabs.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.SpeechToSpeechV1SpeechToSpeechVoiceIdPostOutputFormatExtensions.ToValueString(value));
        }
    }
}
