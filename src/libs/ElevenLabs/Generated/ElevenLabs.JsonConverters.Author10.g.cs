#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Author10JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Author10>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Author10 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketDeadlineChangedEventResponseAuthorDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketDeadlineChangedEventResponseAuthorDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketDeadlineChangedEventResponseAuthorDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.TicketEventRequesterAuthorResponse? requester = default;
            if (discriminator?.Type == global::ElevenLabs.TicketDeadlineChangedEventResponseAuthorDiscriminatorType.Requester)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketEventRequesterAuthorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketEventRequesterAuthorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketEventRequesterAuthorResponse)}");
                requester = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketEventAIAgentAuthorResponse? aiAgent = default;
            if (discriminator?.Type == global::ElevenLabs.TicketDeadlineChangedEventResponseAuthorDiscriminatorType.AiAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketEventAIAgentAuthorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketEventAIAgentAuthorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketEventAIAgentAuthorResponse)}");
                aiAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TicketEventHumanAgentAuthorResponse? humanAgent = default;
            if (discriminator?.Type == global::ElevenLabs.TicketDeadlineChangedEventResponseAuthorDiscriminatorType.HumanAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketEventHumanAgentAuthorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketEventHumanAgentAuthorResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TicketEventHumanAgentAuthorResponse)}");
                humanAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Author10(
                discriminator?.Type,
                requester,

                aiAgent,

                humanAgent
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Author10 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsRequester)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketEventRequesterAuthorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketEventRequesterAuthorResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketEventRequesterAuthorResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRequester(), typeInfo);
            }
            else if (value.IsAiAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketEventAIAgentAuthorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketEventAIAgentAuthorResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketEventAIAgentAuthorResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAiAgent(), typeInfo);
            }
            else if (value.IsHumanAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TicketEventHumanAgentAuthorResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TicketEventHumanAgentAuthorResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TicketEventHumanAgentAuthorResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickHumanAgent(), typeInfo);
            }
        }
    }
}