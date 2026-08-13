#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class VideoReferenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.VideoReference>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.VideoReference Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.VideoReferenceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.VideoReferenceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.VideoReferenceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.GenerationReference? generation = default;
            if (discriminator?.Type == global::ElevenLabs.VideoReferenceDiscriminatorType.Generation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GenerationReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GenerationReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GenerationReference)}");
                generation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.StaticAssetReference? asset = default;
            if (discriminator?.Type == global::ElevenLabs.VideoReferenceDiscriminatorType.Asset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.StaticAssetReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.StaticAssetReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.StaticAssetReference)}");
                asset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.InlineVideoReference? inlineBase64 = default;
            if (discriminator?.Type == global::ElevenLabs.VideoReferenceDiscriminatorType.InlineBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.InlineVideoReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.InlineVideoReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.InlineVideoReference)}");
                inlineBase64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.VideoReference(
                discriminator?.Type,
                generation,

                asset,

                inlineBase64
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.VideoReference value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGeneration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GenerationReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GenerationReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GenerationReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Generation!, typeInfo);
            }
            else if (value.IsAsset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.StaticAssetReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.StaticAssetReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.StaticAssetReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Asset!, typeInfo);
            }
            else if (value.IsInlineBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.InlineVideoReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.InlineVideoReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.InlineVideoReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InlineBase64!, typeInfo);
            }
        }
    }
}