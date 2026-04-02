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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1Discriminator>(ref readerCopy, options);

            global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? webhook = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Webhook)
            {
                webhook = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails>(ref reader, options);
            }
            global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? client = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Client)
            {
                client = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails>(ref reader, options);
            }
            global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? mcp = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails>(ref reader, options);
            }
            global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput? apiIntegrationWebhook = default;
            if (discriminator?.Type == global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelInputToolDetailsVariant1DiscriminatorType.ApiIntegrationWebhook)
            {
                apiIntegrationWebhook = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ToolDetailsVariant1(
                discriminator?.Type,
                webhook,

                client,

                mcp,

                apiIntegrationWebhook
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ToolDetailsVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails), options);
            }
            else if (value.IsClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client, typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails), options);
            }
            else if (value.IsApiIntegrationWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiIntegrationWebhook, typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsInput), options);
            }
        }
    }
}