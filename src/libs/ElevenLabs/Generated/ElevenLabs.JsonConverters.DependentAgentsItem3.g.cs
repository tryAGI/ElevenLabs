#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class DependentAgentsItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.DependentAgentsItem3>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.DependentAgentsItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.DependentAvailableAgentIdentifier? available = default;
            if (discriminator?.Type == global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType.Available)
            {
                available = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DependentAvailableAgentIdentifier>(ref reader, options);
            }
            global::ElevenLabs.DependentUnknownAgentIdentifier? unknown = default;
            if (discriminator?.Type == global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModelDependentAgentDiscriminatorType.Unknown)
            {
                unknown = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DependentUnknownAgentIdentifier>(ref reader, options);
            }

            var __value = new global::ElevenLabs.DependentAgentsItem3(
                discriminator?.Type,
                available,

                unknown
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.DependentAgentsItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsAvailable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Available, typeof(global::ElevenLabs.DependentAvailableAgentIdentifier), options);
            }
            else if (value.IsUnknown)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unknown, typeof(global::ElevenLabs.DependentUnknownAgentIdentifier), options);
            }
        }
    }
}