#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormat>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormat Read(
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
                        return global::ElevenLabs.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.TextToSpeechStreamingWithTimestampsV1TextToSpeechVoiceIdStreamWithTimestampsPostOutputFormatExtensions.ToValueString(value));
        }
    }
}
