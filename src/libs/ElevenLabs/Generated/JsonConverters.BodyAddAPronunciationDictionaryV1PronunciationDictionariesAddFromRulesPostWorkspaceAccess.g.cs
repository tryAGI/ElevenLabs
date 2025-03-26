#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccessJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess Read(
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
                        return global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccessExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccessExtensions.ToValueString(value));
        }
    }
}
