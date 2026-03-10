#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class MCPToolConfigOutputInputOverridesDiscriminatorSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource? Read(
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
                        return global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.MCPToolConfigOutputInputOverridesDiscriminatorSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
