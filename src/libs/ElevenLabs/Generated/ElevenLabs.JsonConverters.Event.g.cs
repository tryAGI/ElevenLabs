#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class EventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Event>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Event Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.StreamEnvelopeEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.StreamEnvelopeEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.StreamEnvelopeEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.StreamEndedEvent? streamEnded = default;
            if (discriminator?.Type == global::ElevenLabs.StreamEnvelopeEventDiscriminatorType.StreamEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.StreamEndedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.StreamEndedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.StreamEndedEvent)}");
                streamEnded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.AgentChatResponsePartClientEvent? agentChatResponsePart = default;
            if (discriminator?.Type == global::ElevenLabs.StreamEnvelopeEventDiscriminatorType.AgentChatResponsePart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentChatResponsePartClientEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentChatResponsePartClientEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AgentChatResponsePartClientEvent)}");
                agentChatResponsePart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.AgentReasoningResponsePartClientEvent? agentReasoningResponsePart = default;
            if (discriminator?.Type == global::ElevenLabs.StreamEnvelopeEventDiscriminatorType.AgentReasoningResponsePart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentReasoningResponsePartClientEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentReasoningResponsePartClientEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AgentReasoningResponsePartClientEvent)}");
                agentReasoningResponsePart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.AgentResponseClientEvent? agentResponse = default;
            if (discriminator?.Type == global::ElevenLabs.StreamEnvelopeEventDiscriminatorType.AgentResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentResponseClientEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentResponseClientEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AgentResponseClientEvent)}");
                agentResponse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.AgentToolRequestStreamedEvent? agentToolRequest = default;
            if (discriminator?.Type == global::ElevenLabs.StreamEnvelopeEventDiscriminatorType.AgentToolRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentToolRequestStreamedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentToolRequestStreamedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AgentToolRequestStreamedEvent)}");
                agentToolRequest = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.AgentToolResponseStreamedEvent? agentToolResponse = default;
            if (discriminator?.Type == global::ElevenLabs.StreamEnvelopeEventDiscriminatorType.AgentToolResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentToolResponseStreamedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentToolResponseStreamedEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AgentToolResponseStreamedEvent)}");
                agentToolResponse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ClientToolCallEvent? clientToolCall = default;
            if (discriminator?.Type == global::ElevenLabs.StreamEnvelopeEventDiscriminatorType.ClientToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ClientToolCallEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ClientToolCallEvent> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ClientToolCallEvent)}");
                clientToolCall = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Event(
                discriminator?.Type,
                streamEnded,

                agentChatResponsePart,

                agentReasoningResponsePart,

                agentResponse,

                agentToolRequest,

                agentToolResponse,

                clientToolCall
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Event value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsStreamEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.StreamEndedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.StreamEndedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.StreamEndedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickStreamEnded(), typeInfo);
            }
            else if (value.IsAgentChatResponsePart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentChatResponsePartClientEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentChatResponsePartClientEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AgentChatResponsePartClientEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentChatResponsePart(), typeInfo);
            }
            else if (value.IsAgentReasoningResponsePart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentReasoningResponsePartClientEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentReasoningResponsePartClientEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AgentReasoningResponsePartClientEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentReasoningResponsePart(), typeInfo);
            }
            else if (value.IsAgentResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentResponseClientEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentResponseClientEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AgentResponseClientEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentResponse(), typeInfo);
            }
            else if (value.IsAgentToolRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentToolRequestStreamedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentToolRequestStreamedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AgentToolRequestStreamedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentToolRequest(), typeInfo);
            }
            else if (value.IsAgentToolResponse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentToolResponseStreamedEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentToolResponseStreamedEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AgentToolResponseStreamedEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAgentToolResponse(), typeInfo);
            }
            else if (value.IsClientToolCall)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ClientToolCallEvent), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ClientToolCallEvent?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ClientToolCallEvent).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickClientToolCall(), typeInfo);
            }
        }
    }
}