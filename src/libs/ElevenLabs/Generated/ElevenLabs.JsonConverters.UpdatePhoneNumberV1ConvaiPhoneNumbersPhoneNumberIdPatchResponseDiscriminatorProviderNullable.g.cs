#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProviderNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProvider?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProvider? Read(
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
                        return global::ElevenLabs.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProviderExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProvider?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProvider? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.UpdatePhoneNumberV1ConvaiPhoneNumbersPhoneNumberIdPatchResponseDiscriminatorProviderExtensions.ToValueString(value.Value));
            }
        }
    }
}
