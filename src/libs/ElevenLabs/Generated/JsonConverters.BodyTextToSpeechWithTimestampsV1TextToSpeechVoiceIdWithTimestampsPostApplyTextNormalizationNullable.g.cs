#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalizationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalization?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalization? Read(
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
                        return global::ElevenLabs.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalizationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalization)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalization? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.BodyTextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostApplyTextNormalizationExtensions.ToValueString(value.Value));
            }
        }
    }
}