#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Config2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Config2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Config2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ExotelTransferOutputConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ExotelTransferOutputConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ExotelTransferOutputConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.ExotelColdBlindTransferConfigOutput? exotelColdBlindTransfer = default;
            if (discriminator?.Type == global::ElevenLabs.ExotelTransferOutputConfigDiscriminatorType.ExotelColdBlindTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ExotelColdBlindTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ExotelColdBlindTransferConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ExotelColdBlindTransferConfigOutput)}");
                exotelColdBlindTransfer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ExotelWarmTransferConfigOutput? exotelWarmTransfer = default;
            if (discriminator?.Type == global::ElevenLabs.ExotelTransferOutputConfigDiscriminatorType.ExotelWarmTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ExotelWarmTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ExotelWarmTransferConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ExotelWarmTransferConfigOutput)}");
                exotelWarmTransfer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Config2(
                discriminator?.Type,
                exotelColdBlindTransfer,

                exotelWarmTransfer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Config2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsExotelColdBlindTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ExotelColdBlindTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ExotelColdBlindTransferConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ExotelColdBlindTransferConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickExotelColdBlindTransfer(), typeInfo);
            }
            else if (value.IsExotelWarmTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ExotelWarmTransferConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ExotelWarmTransferConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ExotelWarmTransferConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickExotelWarmTransfer(), typeInfo);
            }
        }
    }
}