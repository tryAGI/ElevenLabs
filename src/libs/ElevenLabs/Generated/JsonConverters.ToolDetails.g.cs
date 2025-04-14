#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ToolDetailsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ToolDetails>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ToolDetails Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? webhook = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? client = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType.Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails)}");
                client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.ToolDetails(
                discriminator?.Type,
                webhook,
                client
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ToolDetails value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeInfo);
            }
            else if (value.IsClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client, typeInfo);
            }
        }
    }
}