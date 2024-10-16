#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType? Read(
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
                        return global::ElevenLabs.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.GetTranscriptForDubV1DubbingDubbingIdTranscriptLanguageCodeGetFormatTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
