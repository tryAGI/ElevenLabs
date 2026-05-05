#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiIntegrationOAuth2CustomAppResponseScopeSeparatorJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator Read(
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
                        return global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparator value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponseScopeSeparatorExtensions.ToValueString(value));
        }
    }
}
