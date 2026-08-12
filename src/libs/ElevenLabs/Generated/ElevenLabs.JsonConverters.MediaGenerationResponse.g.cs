#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class MediaGenerationResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.MediaGenerationResponse>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.MediaGenerationResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MediaGenerationResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MediaGenerationResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.MediaGenerationResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.MediaGenerationInProgressResponse? generating = default;
            if (discriminator?.Status == global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus.Generating)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MediaGenerationInProgressResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MediaGenerationInProgressResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.MediaGenerationInProgressResponse)}");
                generating = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.MediaGenerationCompletedResponse? completed = default;
            if (discriminator?.Status == global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus.Completed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MediaGenerationCompletedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MediaGenerationCompletedResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.MediaGenerationCompletedResponse)}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.MediaGenerationFailedResponse? failed = default;
            if (discriminator?.Status == global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MediaGenerationFailedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MediaGenerationFailedResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.MediaGenerationFailedResponse)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.MediaGenerationResponse(
                discriminator?.Status,
                generating,

                completed,

                failed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.MediaGenerationResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGenerating)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MediaGenerationInProgressResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MediaGenerationInProgressResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.MediaGenerationInProgressResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Generating!, typeInfo);
            }
            else if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MediaGenerationCompletedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MediaGenerationCompletedResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.MediaGenerationCompletedResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completed!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MediaGenerationFailedResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MediaGenerationFailedResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.MediaGenerationFailedResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
        }
    }
}