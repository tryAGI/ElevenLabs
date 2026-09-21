#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ContentSchemaJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ContentSchema>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ContentSchema Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ContentSchemaDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ContentSchemaDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ContentSchemaDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.StringSchema? @string = default;
            if (discriminator?.Type == global::ElevenLabs.ContentSchemaDiscriminatorType.String)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.StringSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.StringSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.StringSchema)}");
                @string = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.NumberSchema? number = default;
            if (discriminator?.Type == global::ElevenLabs.ContentSchemaDiscriminatorType.Number)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.NumberSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.NumberSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.NumberSchema)}");
                number = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.IntegerSchema? integer = default;
            if (discriminator?.Type == global::ElevenLabs.ContentSchemaDiscriminatorType.Integer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.IntegerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.IntegerSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.IntegerSchema)}");
                integer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BooleanSchema? boolean = default;
            if (discriminator?.Type == global::ElevenLabs.ContentSchemaDiscriminatorType.Boolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BooleanSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BooleanSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BooleanSchema)}");
                boolean = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ImageSchema? image = default;
            if (discriminator?.Type == global::ElevenLabs.ContentSchemaDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ImageSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ImageSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ImageSchema)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.VideoSchema? video = default;
            if (discriminator?.Type == global::ElevenLabs.ContentSchemaDiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.VideoSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.VideoSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.VideoSchema)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.AudioSchema? audio = default;
            if (discriminator?.Type == global::ElevenLabs.ContentSchemaDiscriminatorType.Audio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AudioSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AudioSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AudioSchema)}");
                audio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.VoiceSchema? voice = default;
            if (discriminator?.Type == global::ElevenLabs.ContentSchemaDiscriminatorType.Voice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.VoiceSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.VoiceSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.VoiceSchema)}");
                voice = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ObjectSchema? objectValue = default;
            if (discriminator?.Type == global::ElevenLabs.ContentSchemaDiscriminatorType.Object)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ObjectSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ObjectSchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ObjectSchema)}");
                objectValue = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ArraySchema? array = default;
            if (discriminator?.Type == global::ElevenLabs.ContentSchemaDiscriminatorType.Array)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ArraySchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ArraySchema> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ArraySchema)}");
                array = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.ContentSchema(
                discriminator?.Type,
                @string,

                number,

                integer,

                boolean,

                image,

                video,

                audio,

                voice,

                objectValue,

                array
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ContentSchema value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.StringSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.StringSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.StringSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.String!, typeInfo);
            }
            else if (value.IsNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.NumberSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.NumberSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.NumberSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Number!, typeInfo);
            }
            else if (value.IsInteger)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.IntegerSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.IntegerSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.IntegerSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Integer!, typeInfo);
            }
            else if (value.IsBoolean)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BooleanSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BooleanSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BooleanSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Boolean!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ImageSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ImageSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ImageSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.VideoSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.VideoSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.VideoSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
            else if (value.IsAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AudioSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AudioSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AudioSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Audio!, typeInfo);
            }
            else if (value.IsVoice)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.VoiceSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.VoiceSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.VoiceSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Voice!, typeInfo);
            }
            else if (value.IsObjectValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ObjectSchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ObjectSchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ObjectSchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ObjectValue!, typeInfo);
            }
            else if (value.IsArray)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ArraySchema), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ArraySchema?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ArraySchema).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Array!, typeInfo);
            }
        }
    }
}