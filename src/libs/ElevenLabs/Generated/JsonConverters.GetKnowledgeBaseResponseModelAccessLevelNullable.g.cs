#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetKnowledgeBaseResponseModelAccessLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.GetKnowledgeBaseResponseModelAccessLevel?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.GetKnowledgeBaseResponseModelAccessLevel? Read(
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
                        return global::ElevenLabs.GetKnowledgeBaseResponseModelAccessLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.GetKnowledgeBaseResponseModelAccessLevel)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.GetKnowledgeBaseResponseModelAccessLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.GetKnowledgeBaseResponseModelAccessLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
