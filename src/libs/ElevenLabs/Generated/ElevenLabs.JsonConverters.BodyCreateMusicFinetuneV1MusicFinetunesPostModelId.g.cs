#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyCreateMusicFinetuneV1MusicFinetunesPostModelIdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostModelId>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostModelId Read(
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
                        return global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostModelIdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostModelId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostModelId);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostModelId value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ElevenLabs.BodyCreateMusicFinetuneV1MusicFinetunesPostModelIdExtensions.ToValueString(value));
        }
    }
}
