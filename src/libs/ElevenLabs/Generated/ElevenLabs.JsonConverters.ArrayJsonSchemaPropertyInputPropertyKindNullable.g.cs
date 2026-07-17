#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ArrayJsonSchemaPropertyInputPropertyKindNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind? Read(
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
                        return global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKindExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKind? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.ArrayJsonSchemaPropertyInputPropertyKindExtensions.ToValueString(value.Value));
            }
        }
    }
}
