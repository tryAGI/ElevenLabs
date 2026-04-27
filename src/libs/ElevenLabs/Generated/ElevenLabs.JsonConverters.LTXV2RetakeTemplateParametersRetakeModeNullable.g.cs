#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class LTXV2RetakeTemplateParametersRetakeModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.LTXV2RetakeTemplateParametersRetakeMode?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.LTXV2RetakeTemplateParametersRetakeMode? Read(
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
                        return global::ElevenLabs.LTXV2RetakeTemplateParametersRetakeModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.LTXV2RetakeTemplateParametersRetakeMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.LTXV2RetakeTemplateParametersRetakeMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.LTXV2RetakeTemplateParametersRetakeMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.LTXV2RetakeTemplateParametersRetakeModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
