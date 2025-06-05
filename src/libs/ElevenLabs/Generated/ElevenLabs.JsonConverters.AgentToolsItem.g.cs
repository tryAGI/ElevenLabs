#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class AgentToolsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.AgentToolsItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.AgentToolsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConvAIStoredSecretDependenciesAgentToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConvAIStoredSecretDependenciesAgentToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConvAIStoredSecretDependenciesAgentToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.DependentAvailableAgentToolIdentifier? available = default;
            if (discriminator?.Type == global::ElevenLabs.ConvAIStoredSecretDependenciesAgentToolDiscriminatorType.Available)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentAvailableAgentToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentAvailableAgentToolIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DependentAvailableAgentToolIdentifier)}");
                available = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DependentUnknownAgentToolIdentifier? unknown = default;
            if (discriminator?.Type == global::ElevenLabs.ConvAIStoredSecretDependenciesAgentToolDiscriminatorType.Unknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentUnknownAgentToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentUnknownAgentToolIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DependentUnknownAgentToolIdentifier)}");
                unknown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.AgentToolsItem(
                discriminator?.Type,
                available,
                unknown
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.AgentToolsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAvailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentAvailableAgentToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentAvailableAgentToolIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DependentAvailableAgentToolIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Available, typeInfo);
            }
            else if (value.IsUnknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentUnknownAgentToolIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentUnknownAgentToolIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DependentUnknownAgentToolIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeInfo);
            }
        }
    }
}