#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class VideoGenerationRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.VideoGenerationRequest>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.VideoGenerationRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.VideoGenerationRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.VideoGenerationRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.VideoGenerationRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.CreatifyAuroraRequest? creatifyAurora = default;
            if (discriminator?.ModelId == global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId.CreatifyAurora)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreatifyAuroraRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreatifyAuroraRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreatifyAuroraRequest)}");
                creatifyAurora = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.Veo31Request? veo31Generate001 = default;
            if (discriminator?.ModelId == global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId.Veo31Generate001)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Veo31Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Veo31Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Veo31Request)}");
                veo31Generate001 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.Veo31FastRequest? veo31FastGenerate001 = default;
            if (discriminator?.ModelId == global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId.Veo31FastGenerate001)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Veo31FastRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Veo31FastRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Veo31FastRequest)}");
                veo31FastGenerate001 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BytedanceSeedance2Request? bytedanceSeedanceV2 = default;
            if (discriminator?.ModelId == global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedance2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedance2Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BytedanceSeedance2Request)}");
                bytedanceSeedanceV2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BytedanceSeedance2FastRequest? bytedanceSeedanceV2Fast = default;
            if (discriminator?.ModelId == global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV2Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedance2FastRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedance2FastRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BytedanceSeedance2FastRequest)}");
                bytedanceSeedanceV2Fast = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BytedanceSeedance2MiniRequest? bytedanceSeedanceV2Mini = default;
            if (discriminator?.ModelId == global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV2Mini)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedance2MiniRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedance2MiniRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BytedanceSeedance2MiniRequest)}");
                bytedanceSeedanceV2Mini = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BytedanceSeedance25Request? bytedanceSeedanceV25 = default;
            if (discriminator?.ModelId == global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId.BytedanceSeedanceV25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedance25Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedance25Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BytedanceSeedance25Request)}");
                bytedanceSeedanceV25 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.VideoGenerationRequest(
                discriminator?.ModelId,
                creatifyAurora,

                veo31Generate001,

                veo31FastGenerate001,

                bytedanceSeedanceV2,

                bytedanceSeedanceV2Fast,

                bytedanceSeedanceV2Mini,

                bytedanceSeedanceV25
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.VideoGenerationRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreatifyAurora)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreatifyAuroraRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreatifyAuroraRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CreatifyAuroraRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreatifyAurora!, typeInfo);
            }
            else if (value.IsVeo31Generate001)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Veo31Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Veo31Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Veo31Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31Generate001!, typeInfo);
            }
            else if (value.IsVeo31FastGenerate001)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Veo31FastRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Veo31FastRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Veo31FastRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31FastGenerate001!, typeInfo);
            }
            else if (value.IsBytedanceSeedanceV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedance2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedance2Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BytedanceSeedance2Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BytedanceSeedanceV2!, typeInfo);
            }
            else if (value.IsBytedanceSeedanceV2Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedance2FastRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedance2FastRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BytedanceSeedance2FastRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BytedanceSeedanceV2Fast!, typeInfo);
            }
            else if (value.IsBytedanceSeedanceV2Mini)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedance2MiniRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedance2MiniRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BytedanceSeedance2MiniRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BytedanceSeedanceV2Mini!, typeInfo);
            }
            else if (value.IsBytedanceSeedanceV25)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedance25Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedance25Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BytedanceSeedance25Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BytedanceSeedanceV25!, typeInfo);
            }
        }
    }
}