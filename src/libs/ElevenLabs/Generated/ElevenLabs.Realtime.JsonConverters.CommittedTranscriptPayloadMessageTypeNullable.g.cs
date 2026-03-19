#nullable enable

namespace ElevenLabs.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class CommittedTranscriptPayloadMessageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Realtime.CommittedTranscriptPayloadMessageType?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Realtime.CommittedTranscriptPayloadMessageType? Read(
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
                        return global::ElevenLabs.Realtime.CommittedTranscriptPayloadMessageTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.Realtime.CommittedTranscriptPayloadMessageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.Realtime.CommittedTranscriptPayloadMessageType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Realtime.CommittedTranscriptPayloadMessageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.Realtime.CommittedTranscriptPayloadMessageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
