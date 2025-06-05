#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConversationHistoryTwilioPhoneCallModelTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ConversationHistoryTwilioPhoneCallModelType>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ConversationHistoryTwilioPhoneCallModelType Read(
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
                        return global::ElevenLabs.ConversationHistoryTwilioPhoneCallModelTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.ConversationHistoryTwilioPhoneCallModelType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModelType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ConversationHistoryTwilioPhoneCallModelType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModelTypeExtensions.ToValueString(value));
        }
    }
}
