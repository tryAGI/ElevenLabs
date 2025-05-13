#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType Read(
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
                        return global::ElevenLabs.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
