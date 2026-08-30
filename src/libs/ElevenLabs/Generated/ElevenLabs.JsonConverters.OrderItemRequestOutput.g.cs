#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class OrderItemRequestOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.OrderItemRequestOutput>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.OrderItemRequestOutput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OrderItemRequestOutputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.OrderItemRequestOutputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.DubOrderItemRequest? dub = default;
            if (discriminator?.Kind == global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind.Dub)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DubOrderItemRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DubOrderItemRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DubOrderItemRequest)}");
                dub = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SubtitleOrderItemRequest? subtitles = default;
            if (discriminator?.Kind == global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind.Subtitles)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SubtitleOrderItemRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SubtitleOrderItemRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SubtitleOrderItemRequest)}");
                subtitles = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TranscriptionOrderItemRequest? transcription = default;
            if (discriminator?.Kind == global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind.Transcription)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TranscriptionOrderItemRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TranscriptionOrderItemRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TranscriptionOrderItemRequest)}");
                transcription = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.OrderItemRequestOutput(
                discriminator?.Kind,
                dub,

                subtitles,

                transcription
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.OrderItemRequestOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDub)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DubOrderItemRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DubOrderItemRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DubOrderItemRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dub!, typeInfo);
            }
            else if (value.IsSubtitles)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SubtitleOrderItemRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SubtitleOrderItemRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SubtitleOrderItemRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Subtitles!, typeInfo);
            }
            else if (value.IsTranscription)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TranscriptionOrderItemRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TranscriptionOrderItemRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TranscriptionOrderItemRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Transcription!, typeInfo);
            }
        }
    }
}