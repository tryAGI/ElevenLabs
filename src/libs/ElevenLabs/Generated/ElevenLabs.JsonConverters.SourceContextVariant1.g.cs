#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class SourceContextVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.SourceContextVariant1>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.SourceContextVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1Discriminator>(ref readerCopy, options);

            global::ElevenLabs.SongSourceContext? musicExploreSong1 = default;
            if (discriminator?.SourceType == global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.MusicExploreSong)
            {
                musicExploreSong1 = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SongSourceContext>(ref reader, options);
            }
            global::ElevenLabs.MusicExploreSongSourceContext? musicExploreSong2 = default;
            if (discriminator?.SourceType == global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.MusicExploreSong)
            {
                musicExploreSong2 = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.MusicExploreSongSourceContext>(ref reader, options);
            }
            global::ElevenLabs.SfxSourceContext? sfx = default;
            if (discriminator?.SourceType == global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType.Sfx)
            {
                sfx = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SfxSourceContext>(ref reader, options);
            }

            var __value = new global::ElevenLabs.SourceContextVariant1(
                discriminator?.SourceType,
                musicExploreSong1,

                musicExploreSong2,

                sfx
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.SourceContextVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsMusicExploreSong1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MusicExploreSong1, typeof(global::ElevenLabs.SongSourceContext), options);
            }
            else if (value.IsMusicExploreSong2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MusicExploreSong2, typeof(global::ElevenLabs.MusicExploreSongSourceContext), options);
            }
            else if (value.IsSfx)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sfx, typeof(global::ElevenLabs.SfxSourceContext), options);
            }
        }
    }
}