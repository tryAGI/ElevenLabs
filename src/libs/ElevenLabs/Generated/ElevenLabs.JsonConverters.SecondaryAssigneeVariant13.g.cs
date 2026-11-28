#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class SecondaryAssigneeVariant13JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.SecondaryAssigneeVariant13>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.SecondaryAssigneeVariant13 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateTicketRequestSecondaryAssigneeVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateTicketRequestSecondaryAssigneeVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateTicketRequestSecondaryAssigneeVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.TicketAIAgentAssigneeRequest? aiAgent = default;
            if (discriminator?.Type == global::ElevenLabs.UpdateTicketRequestSecondaryAssigneeVariant1DiscriminatorType.AiAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketAIAgentAssigneeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketAIAgentAssigneeRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketAIAgentAssigneeRequest)}");
                aiAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketHumanAgentAssigneeRequest? humanAgent = default;
            if (discriminator?.Type == global::ElevenLabs.UpdateTicketRequestSecondaryAssigneeVariant1DiscriminatorType.HumanAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketHumanAgentAssigneeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketHumanAgentAssigneeRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketHumanAgentAssigneeRequest)}");
                humanAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.SecondaryAssigneeVariant13(
                discriminator?.Type,
                aiAgent,

                humanAgent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.SecondaryAssigneeVariant13 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsAiAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketAIAgentAssigneeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketAIAgentAssigneeRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketAIAgentAssigneeRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAiAgent(), typeInfo);
            }
            else if (value.IsHumanAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketHumanAgentAssigneeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketHumanAgentAssigneeRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketHumanAgentAssigneeRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHumanAgent(), typeInfo);
            }
        }
    }
}