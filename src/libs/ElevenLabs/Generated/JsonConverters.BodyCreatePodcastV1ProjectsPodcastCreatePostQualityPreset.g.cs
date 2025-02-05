#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPresetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset Read(
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
                        return global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPresetExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPreset value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.BodyCreatePodcastV1ProjectsPodcastCreatePostQualityPresetExtensions.ToValueString(value));
        }
    }
}
