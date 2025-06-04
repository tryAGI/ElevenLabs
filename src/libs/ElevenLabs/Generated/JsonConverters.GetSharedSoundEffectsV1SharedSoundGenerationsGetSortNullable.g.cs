#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSharedSoundEffectsV1SharedSoundGenerationsGetSortNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.GetSharedSoundEffectsV1SharedSoundGenerationsGetSort?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.GetSharedSoundEffectsV1SharedSoundGenerationsGetSort? Read(
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
                        return global::ElevenLabs.GetSharedSoundEffectsV1SharedSoundGenerationsGetSortExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.GetSharedSoundEffectsV1SharedSoundGenerationsGetSort)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.GetSharedSoundEffectsV1SharedSoundGenerationsGetSort?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.GetSharedSoundEffectsV1SharedSoundGenerationsGetSort? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.GetSharedSoundEffectsV1SharedSoundGenerationsGetSortExtensions.ToValueString(value.Value));
            }
        }
    }
}
