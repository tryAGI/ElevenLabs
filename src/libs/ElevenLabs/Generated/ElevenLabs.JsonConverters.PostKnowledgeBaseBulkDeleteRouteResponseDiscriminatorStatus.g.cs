#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus Read(
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
                        return global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatusExtensions.ToValueString(value));
        }
    }
}
