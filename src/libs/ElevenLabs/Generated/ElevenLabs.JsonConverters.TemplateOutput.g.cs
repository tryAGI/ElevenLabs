#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class TemplateOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.TemplateOutput>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.TemplateOutput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateOutputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateOutputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TemplateOutputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.TemplateImageOutput? image = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateOutputDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateImageOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateImageOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TemplateImageOutput)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TemplateVideoOutput? video = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateOutputDiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateVideoOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateVideoOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TemplateVideoOutput)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TemplateAudioOutput? audio = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateOutputDiscriminatorType.Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateAudioOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateAudioOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TemplateAudioOutput)}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TemplateStringOutput? @string = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateOutputDiscriminatorType.String)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateStringOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateStringOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TemplateStringOutput)}");
                @string = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TemplateIntegerOutput? integer = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateOutputDiscriminatorType.Integer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateIntegerOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateIntegerOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TemplateIntegerOutput)}");
                integer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TemplateNumberOutput? number = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateOutputDiscriminatorType.Number)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateNumberOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateNumberOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TemplateNumberOutput)}");
                number = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TemplateBooleanOutput? boolean = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateOutputDiscriminatorType.Boolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateBooleanOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateBooleanOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TemplateBooleanOutput)}");
                boolean = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TemplateArrayOutput? array = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateOutputDiscriminatorType.Array)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateArrayOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateArrayOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TemplateArrayOutput)}");
                array = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TemplateObjectOutput? objectValue = default;
            if (discriminator?.Type == global::ElevenLabs.TemplateOutputDiscriminatorType.Object)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateObjectOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateObjectOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TemplateObjectOutput)}");
                objectValue = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.TemplateOutput(
                discriminator?.Type,
                image,

                video,

                audio,

                @string,

                integer,

                number,

                boolean,

                array,

                objectValue
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.TemplateOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateImageOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateImageOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TemplateImageOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateVideoOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateVideoOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TemplateVideoOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
            else if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateAudioOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateAudioOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TemplateAudioOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
            else if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateStringOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateStringOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TemplateStringOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String!, typeInfo);
            }
            else if (value.IsInteger)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateIntegerOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateIntegerOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TemplateIntegerOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Integer!, typeInfo);
            }
            else if (value.IsNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateNumberOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateNumberOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TemplateNumberOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Number!, typeInfo);
            }
            else if (value.IsBoolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateBooleanOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateBooleanOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TemplateBooleanOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Boolean!, typeInfo);
            }
            else if (value.IsArray)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateArrayOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateArrayOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TemplateArrayOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Array!, typeInfo);
            }
            else if (value.IsObjectValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TemplateObjectOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TemplateObjectOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TemplateObjectOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ObjectValue!, typeInfo);
            }
        }
    }
}