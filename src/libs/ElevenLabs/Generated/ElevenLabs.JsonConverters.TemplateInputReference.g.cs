#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class TemplateInputReferenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TemplateInputReference>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TemplateInputReference Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateInputReferenceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateInputReferenceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TemplateInputReferenceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.GenerationReference? generation = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateInputReferenceDiscriminatorType.Generation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GenerationReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GenerationReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GenerationReference)}");
                generation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.StaticAssetReference? asset = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateInputReferenceDiscriminatorType.Asset)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.StaticAssetReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.StaticAssetReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.StaticAssetReference)}");
                asset = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.VoiceReference? voice = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateInputReferenceDiscriminatorType.Voice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.VoiceReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.VoiceReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.VoiceReference)}");
                voice = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.InlineBase64Reference? inlineBase64 = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateInputReferenceDiscriminatorType.InlineBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.InlineBase64Reference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.InlineBase64Reference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.InlineBase64Reference)}");
                inlineBase64 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.TemplateInputReference(
                discriminator?.Type,
                generation,

                asset,

                voice,

                inlineBase64
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TemplateInputReference value,
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
            else if (value.IsVoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.VoiceReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.VoiceReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.VoiceReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voice!, typeInfo);
            }
            else if (value.IsInlineBase64)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.InlineBase64Reference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.InlineBase64Reference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.InlineBase64Reference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.InlineBase64!, typeInfo);
            }
        }
    }
}