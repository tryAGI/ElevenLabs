#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class McpServersItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.McpServersItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.McpServersItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.DependentAvailableMCPServerIdentifier? available = default;
            if (discriminator?.Type == global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType.Available)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentAvailableMCPServerIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DependentAvailableMCPServerIdentifier)}");
                available = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DependentUnknownMCPServerIdentifier? unknown = default;
            if (discriminator?.Type == global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType.Unknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentUnknownMCPServerIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentUnknownMCPServerIdentifier> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DependentUnknownMCPServerIdentifier)}");
                unknown = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.McpServersItem(
                discriminator?.Type,
                available,

                unknown
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.McpServersItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAvailable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentAvailableMCPServerIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Available, typeInfo);
            }
            else if (value.IsUnknown)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DependentUnknownMCPServerIdentifier), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DependentUnknownMCPServerIdentifier?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DependentUnknownMCPServerIdentifier).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeInfo);
            }
        }
    }
}