#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus Read(
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
                        return global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatusExtensions.ToValueString(value));
        }
    }
}
