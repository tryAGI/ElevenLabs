#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource? Read(
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
                        return global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSourceExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
