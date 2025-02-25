#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class AgentsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.AgentsItem2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.AgentsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.DependentAvailableAgentIdentifier? available = default;
            if (discriminator?.Type == global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType.Available)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentAvailableAgentIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentAvailableAgentIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DependentAvailableAgentIdentifier)}");
                available = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DependentUnknownAgentIdentifier? unknown = default;
            if (discriminator?.Type == global::ElevenLabs.GetKnowledgeBaseDependentAgentsResponseModelAgentDiscriminatorType.Unknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentUnknownAgentIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentUnknownAgentIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DependentUnknownAgentIdentifier)}");
                unknown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.AgentsItem2(
                discriminator?.Type,
                available,
                unknown
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.AgentsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAvailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentAvailableAgentIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentAvailableAgentIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DependentAvailableAgentIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Available, typeInfo);
            }
            else if (value.IsUnknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentUnknownAgentIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentUnknownAgentIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DependentUnknownAgentIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeInfo);
            }
        }
    }
}