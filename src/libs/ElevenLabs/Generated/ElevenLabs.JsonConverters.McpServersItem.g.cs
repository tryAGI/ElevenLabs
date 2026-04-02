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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.DependentAvailableMCPServerIdentifier? available = default;
            if (discriminator?.Type == global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType.Available)
            {
                available = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DependentAvailableMCPServerIdentifier>(ref reader, options);
            }
            global::ElevenLabs.DependentUnknownMCPServerIdentifier? unknown = default;
            if (discriminator?.Type == global::ElevenLabs.AuthConnectionDependenciesMcpServerDiscriminatorType.Unknown)
            {
                unknown = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DependentUnknownMCPServerIdentifier>(ref reader, options);
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

            if (value.IsAvailable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Available, typeof(global::ElevenLabs.DependentAvailableMCPServerIdentifier), options);
            }
            else if (value.IsUnknown)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeof(global::ElevenLabs.DependentUnknownMCPServerIdentifier), options);
            }
        }
    }
}