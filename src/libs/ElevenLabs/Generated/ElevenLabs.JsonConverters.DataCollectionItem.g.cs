#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class DataCollectionItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.DataCollectionItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.DataCollectionItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.AttachedUserDataCollectionRef? user = default;
            if (discriminator?.Source == global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AttachedUserDataCollectionRef), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AttachedUserDataCollectionRef> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AttachedUserDataCollectionRef)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.AttachedSystemDataCollectionRef? system = default;
            if (discriminator?.Source == global::ElevenLabs.AgentAnalysisItemsInputDataCollectionItemDiscriminatorSource.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AttachedSystemDataCollectionRef), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AttachedSystemDataCollectionRef> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AttachedSystemDataCollectionRef)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.DataCollectionItem(
                discriminator?.Source,
                user,

                system
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.DataCollectionItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AttachedUserDataCollectionRef), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AttachedUserDataCollectionRef?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AttachedUserDataCollectionRef).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User!, typeInfo);
            }
            else if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AttachedSystemDataCollectionRef), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AttachedSystemDataCollectionRef?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AttachedSystemDataCollectionRef).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System!, typeInfo);
            }
        }
    }
}