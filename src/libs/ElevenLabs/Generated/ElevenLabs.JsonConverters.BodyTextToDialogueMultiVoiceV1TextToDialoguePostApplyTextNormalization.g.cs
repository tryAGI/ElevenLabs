#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization Read(
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
                        return global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationExtensions.ToValueString(value));
        }
    }
}
