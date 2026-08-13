#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class WebhookTargetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.WebhookTarget>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.WebhookTarget Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WebhookTargetDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WebhookTargetDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WebhookTargetDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.WebhookTargetAll? all = default;
            if (discriminator?.Type == global::ElevenLabs.WebhookTargetDiscriminatorType.All)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WebhookTargetAll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WebhookTargetAll> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WebhookTargetAll)}");
                all = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WebhookTargetIds? ids = default;
            if (discriminator?.Type == global::ElevenLabs.WebhookTargetDiscriminatorType.Ids)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WebhookTargetIds), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WebhookTargetIds> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WebhookTargetIds)}");
                ids = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.WebhookTarget(
                discriminator?.Type,
                all,

                ids
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.WebhookTarget value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WebhookTargetAll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WebhookTargetAll?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WebhookTargetAll).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.All!, typeInfo);
            }
            else if (value.IsIds)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WebhookTargetIds), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WebhookTargetIds?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WebhookTargetIds).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ids!, typeInfo);
            }
        }
    }
}