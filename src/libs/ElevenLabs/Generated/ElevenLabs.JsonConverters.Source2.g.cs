#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Source2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Source2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Source2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.FileContentPartSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.FileContentPartSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.FileContentPartSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.Base64FileSource? base64 = default;
            if (discriminator?.Type == global::ElevenLabs.FileContentPartSourceDiscriminatorType.Base64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Base64FileSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Base64FileSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Base64FileSource)}");
                base64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.FileIdSource? fileId = default;
            if (discriminator?.Type == global::ElevenLabs.FileContentPartSourceDiscriminatorType.FileId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.FileIdSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.FileIdSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.FileIdSource)}");
                fileId = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Source2(
                discriminator?.Type,
                base64,

                fileId
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Source2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Base64FileSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Base64FileSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Base64FileSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBase64(), typeInfo);
            }
            else if (value.IsFileId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.FileIdSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.FileIdSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.FileIdSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFileId(), typeInfo);
            }
        }
    }
}