#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ToolDetailsVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ToolDetailsVariant1>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ToolDetailsVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? webhook = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? client = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails)}");
                client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? mcp = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails? apiIntegrationWebhook = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.ApiIntegrationWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails)}");
                apiIntegrationWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.ToolDetailsVariant1(
                discriminator?.Type,
                webhook,
                client,
                mcp,
                apiIntegrationWebhook
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ToolDetailsVariant1 value,
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
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
            else if (value.IsApiIntegrationWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetails).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiIntegrationWebhook, typeInfo);
            }
        }
    }
}