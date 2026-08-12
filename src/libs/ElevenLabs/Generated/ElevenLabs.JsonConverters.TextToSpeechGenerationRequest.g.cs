#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class TextToSpeechGenerationRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TextToSpeechGenerationRequest>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TextToSpeechGenerationRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TextToSpeechGenerationRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.ElevenFlashV25Request? elevenFlashV25 = default;
            if (discriminator?.ModelId == global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId.ElevenFlashV25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ElevenFlashV25Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ElevenFlashV25Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ElevenFlashV25Request)}");
                elevenFlashV25 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ElevenMultilingualV2Request? elevenMultilingualV2 = default;
            if (discriminator?.ModelId == global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId.ElevenMultilingualV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ElevenMultilingualV2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ElevenMultilingualV2Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ElevenMultilingualV2Request)}");
                elevenMultilingualV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ElevenV3Request? elevenV3 = default;
            if (discriminator?.ModelId == global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId.ElevenV3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ElevenV3Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ElevenV3Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ElevenV3Request)}");
                elevenV3 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.TextToSpeechGenerationRequest(
                discriminator?.ModelId,
                elevenFlashV25,

                elevenMultilingualV2,

                elevenV3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TextToSpeechGenerationRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsElevenFlashV25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ElevenFlashV25Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ElevenFlashV25Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ElevenFlashV25Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenFlashV25!, typeInfo);
            }
            else if (value.IsElevenMultilingualV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ElevenMultilingualV2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ElevenMultilingualV2Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ElevenMultilingualV2Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenMultilingualV2!, typeInfo);
            }
            else if (value.IsElevenV3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ElevenV3Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ElevenV3Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ElevenV3Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenV3!, typeInfo);
            }
        }
    }
}