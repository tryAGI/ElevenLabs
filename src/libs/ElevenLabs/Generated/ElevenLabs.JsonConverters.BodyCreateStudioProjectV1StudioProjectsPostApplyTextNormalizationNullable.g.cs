#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalizationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization? Read(
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
                        return global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalizationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalizationExtensions.ToValueString(value.Value));
            }
        }
    }
}
