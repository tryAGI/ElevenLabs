#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ImageReferenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ImageReference>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ImageReference Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ImageReferenceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ImageReferenceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ImageReferenceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.GenerationReference? generation = default;
            if (discriminator?.Type == global::ElevenLabs.ImageReferenceDiscriminatorType.Generation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GenerationReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GenerationReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GenerationReference)}");
                generation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.StaticAssetReference? asset = default;
            if (discriminator?.Type == global::ElevenLabs.ImageReferenceDiscriminatorType.Asset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.StaticAssetReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.StaticAssetReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.StaticAssetReference)}");
                asset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.InlineImageReference? inlineBase64 = default;
            if (discriminator?.Type == global::ElevenLabs.ImageReferenceDiscriminatorType.InlineBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.InlineImageReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.InlineImageReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.InlineImageReference)}");
                inlineBase64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.ImageReference(
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
            global::ElevenLabs.ImageReference value,
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.InlineImageReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.InlineImageReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.InlineImageReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InlineBase64!, typeInfo);
            }
        }
    }
}