#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class PlatformMetadataVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.PlatformMetadataVariant1>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.PlatformMetadataVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.PlainPlatformMetadata? plainIntegration = default;
            if (discriminator?.ConversationInitiationSource == global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource.PlainIntegration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PlainPlatformMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PlainPlatformMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PlainPlatformMetadata)}");
                plainIntegration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ZendeskPlatformMetadata? zendeskIntegration = default;
            if (discriminator?.ConversationInitiationSource == global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource.ZendeskIntegration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ZendeskPlatformMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ZendeskPlatformMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ZendeskPlatformMetadata)}");
                zendeskIntegration = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.PlatformMetadataVariant1(
                discriminator?.ConversationInitiationSource,
                plainIntegration,

                zendeskIntegration
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.PlatformMetadataVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsPlainIntegration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PlainPlatformMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PlainPlatformMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PlainPlatformMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickPlainIntegration(), typeInfo);
            }
            else if (value.IsZendeskIntegration)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ZendeskPlatformMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ZendeskPlatformMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ZendeskPlatformMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickZendeskIntegration(), typeInfo);
            }
        }
    }
}