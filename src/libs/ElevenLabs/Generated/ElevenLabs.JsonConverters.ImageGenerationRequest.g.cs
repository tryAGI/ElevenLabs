#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ImageGenerationRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ImageGenerationRequest>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ImageGenerationRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ImageGenerationRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ImageGenerationRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ImageGenerationRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.GPTImage1Request? gptImage1 = default;
            if (discriminator?.ModelId == global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId.GptImage1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GPTImage1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GPTImage1Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GPTImage1Request)}");
                gptImage1 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GPTImage15Request? gptImage15 = default;
            if (discriminator?.ModelId == global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId.GptImage15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GPTImage15Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GPTImage15Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GPTImage15Request)}");
                gptImage15 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GPTImage2Request? gptImage2 = default;
            if (discriminator?.ModelId == global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId.GptImage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GPTImage2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GPTImage2Request> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GPTImage2Request)}");
                gptImage2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.Gemini25FlashImageRequest? gemini25FlashImage = default;
            if (discriminator?.ModelId == global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId.Gemini25FlashImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Gemini25FlashImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Gemini25FlashImageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Gemini25FlashImageRequest)}");
                gemini25FlashImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.Gemini3ProImageRequest? gemini3ProImage = default;
            if (discriminator?.ModelId == global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId.Gemini3ProImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Gemini3ProImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Gemini3ProImageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Gemini3ProImageRequest)}");
                gemini3ProImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.Gemini31FlashImageRequest? gemini31FlashImage = default;
            if (discriminator?.ModelId == global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId.Gemini31FlashImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Gemini31FlashImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Gemini31FlashImageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Gemini31FlashImageRequest)}");
                gemini31FlashImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.Gemini31FlashLiteImageRequest? gemini31FlashLiteImage = default;
            if (discriminator?.ModelId == global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId.Gemini31FlashLiteImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Gemini31FlashLiteImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Gemini31FlashLiteImageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.Gemini31FlashLiteImageRequest)}");
                gemini31FlashLiteImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BytedanceSeedream5LiteRequest? bytedanceSeedream5Lite = default;
            if (discriminator?.ModelId == global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId.BytedanceSeedream5Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedream5LiteRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedream5LiteRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BytedanceSeedream5LiteRequest)}");
                bytedanceSeedream5Lite = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BytedanceSeedream5ProRequest? bytedanceSeedream5Pro = default;
            if (discriminator?.ModelId == global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId.BytedanceSeedream5Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedream5ProRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedream5ProRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BytedanceSeedream5ProRequest)}");
                bytedanceSeedream5Pro = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.ImageGenerationRequest(
                discriminator?.ModelId,
                gptImage1,

                gptImage15,

                gptImage2,

                gemini25FlashImage,

                gemini3ProImage,

                gemini31FlashImage,

                gemini31FlashLiteImage,

                bytedanceSeedream5Lite,

                bytedanceSeedream5Pro
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ImageGenerationRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGptImage1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GPTImage1Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GPTImage1Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GPTImage1Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GptImage1!, typeInfo);
            }
            else if (value.IsGptImage15)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GPTImage15Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GPTImage15Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GPTImage15Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GptImage15!, typeInfo);
            }
            else if (value.IsGptImage2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GPTImage2Request), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GPTImage2Request?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GPTImage2Request).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GptImage2!, typeInfo);
            }
            else if (value.IsGemini25FlashImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Gemini25FlashImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Gemini25FlashImageRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Gemini25FlashImageRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gemini25FlashImage!, typeInfo);
            }
            else if (value.IsGemini3ProImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Gemini3ProImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Gemini3ProImageRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Gemini3ProImageRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gemini3ProImage!, typeInfo);
            }
            else if (value.IsGemini31FlashImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Gemini31FlashImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Gemini31FlashImageRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Gemini31FlashImageRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gemini31FlashImage!, typeInfo);
            }
            else if (value.IsGemini31FlashLiteImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.Gemini31FlashLiteImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.Gemini31FlashLiteImageRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.Gemini31FlashLiteImageRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gemini31FlashLiteImage!, typeInfo);
            }
            else if (value.IsBytedanceSeedream5Lite)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedream5LiteRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedream5LiteRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BytedanceSeedream5LiteRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BytedanceSeedream5Lite!, typeInfo);
            }
            else if (value.IsBytedanceSeedream5Pro)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BytedanceSeedream5ProRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BytedanceSeedream5ProRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BytedanceSeedream5ProRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BytedanceSeedream5Pro!, typeInfo);
            }
        }
    }
}