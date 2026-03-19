#nullable enable

namespace ElevenLabs.Realtime.JsonConverters
{
    /// <inheritdoc />
    public sealed class CommittedTranscriptWithTimestampsPayloadMessageTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayloadMessageType?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayloadMessageType? Read(
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
                        return global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayloadMessageTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayloadMessageType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayloadMessageType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayloadMessageType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayloadMessageTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
