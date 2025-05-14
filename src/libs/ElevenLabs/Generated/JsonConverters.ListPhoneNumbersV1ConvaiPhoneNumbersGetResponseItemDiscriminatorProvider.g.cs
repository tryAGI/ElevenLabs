#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProviderJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider Read(
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
                        return global::ElevenLabs.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProviderExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProviderExtensions.ToValueString(value));
        }
    }
}
