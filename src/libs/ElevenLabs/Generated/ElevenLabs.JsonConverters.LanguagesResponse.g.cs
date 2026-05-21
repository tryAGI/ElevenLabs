#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class LanguagesResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.LanguagesResponse>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.LanguagesResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.LanguagesResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.LanguagesResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.LanguagesResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.PairedLanguagesResponse? pair = default;
            if (discriminator?.Kind == global::ElevenLabs.LanguagesResponseDiscriminatorKind.Pair)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PairedLanguagesResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PairedLanguagesResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PairedLanguagesResponse)}");
                pair = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SingleLanguagesResponse? single = default;
            if (discriminator?.Kind == global::ElevenLabs.LanguagesResponseDiscriminatorKind.Single)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SingleLanguagesResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SingleLanguagesResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SingleLanguagesResponse)}");
                single = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.LanguagesResponse(
                discriminator?.Kind,
                pair,

                single
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.LanguagesResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPair)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PairedLanguagesResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PairedLanguagesResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PairedLanguagesResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pair!, typeInfo);
            }
            else if (value.IsSingle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SingleLanguagesResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SingleLanguagesResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SingleLanguagesResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Single!, typeInfo);
            }
        }
    }
}