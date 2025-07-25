#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType Read(
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
                        return global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelResultDiscriminatorResultTypeExtensions.ToValueString(value));
        }
    }
}
