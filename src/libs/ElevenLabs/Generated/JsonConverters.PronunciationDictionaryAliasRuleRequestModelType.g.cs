#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class PronunciationDictionaryAliasRuleRequestModelTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModelType>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModelType Read(
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
                        return global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModelTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModelType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModelType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModelType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModelTypeExtensions.ToValueString(value));
        }
    }
}
