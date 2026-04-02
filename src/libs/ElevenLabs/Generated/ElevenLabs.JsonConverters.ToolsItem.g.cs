#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ToolsItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ToolsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.AuthConnectionDependenciesToolDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.DependentAvailableToolIdentifier? available = default;
            if (discriminator?.Type == global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType.Available)
            {
                available = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DependentAvailableToolIdentifier>(ref reader, options);
            }
            global::ElevenLabs.DependentUnknownToolIdentifier? unknown = default;
            if (discriminator?.Type == global::ElevenLabs.AuthConnectionDependenciesToolDiscriminatorType.Unknown)
            {
                unknown = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DependentUnknownToolIdentifier>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ToolsItem(
                discriminator?.Type,
                available,

                unknown
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ToolsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAvailable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Available, typeof(global::ElevenLabs.DependentAvailableToolIdentifier), options);
            }
            else if (value.IsUnknown)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeof(global::ElevenLabs.DependentUnknownToolIdentifier), options);
            }
        }
    }
}