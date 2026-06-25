#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class UUITransferConfigProtocolDiscriminatorModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode? Read(
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
                        return global::ElevenLabs.UUITransferConfigProtocolDiscriminatorModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.UUITransferConfigProtocolDiscriminatorMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.UUITransferConfigProtocolDiscriminatorModeExtensions.ToValueString(value.Value));
            }
        }
    }
}
