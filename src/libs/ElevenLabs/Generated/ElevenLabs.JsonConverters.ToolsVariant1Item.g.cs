#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ToolsVariant1ItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ToolsVariant1Item>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ToolsVariant1Item Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.WebhookToolConfigInput? webhook = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Webhook)
            {
                webhook = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WebhookToolConfigInput>(ref reader, options);
            }
            global::ElevenLabs.ClientToolConfigInput? client = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Client)
            {
                client = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ClientToolConfigInput>(ref reader, options);
            }
            global::ElevenLabs.SystemToolConfigInput? system = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.System)
            {
                system = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SystemToolConfigInput>(ref reader, options);
            }
            global::ElevenLabs.MCPToolConfigInput? mcp = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.MCPToolConfigInput>(ref reader, options);
            }
            global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? apiIntegrationWebhook = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.ApiIntegrationWebhook)
            {
                apiIntegrationWebhook = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ApiIntegrationWebhookToolConfigInput>(ref reader, options);
            }
            global::ElevenLabs.SMBToolConfig? smb = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType.Smb)
            {
                smb = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SMBToolConfig>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ToolsVariant1Item(
                discriminator?.Type,
                webhook,

                client,

                system,

                mcp,

                apiIntegrationWebhook,

                smb
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ToolsVariant1Item value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeof(global::ElevenLabs.WebhookToolConfigInput), options);
            }
            else if (value.IsClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client, typeof(global::ElevenLabs.ClientToolConfigInput), options);
            }
            else if (value.IsSystem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeof(global::ElevenLabs.SystemToolConfigInput), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::ElevenLabs.MCPToolConfigInput), options);
            }
            else if (value.IsApiIntegrationWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiIntegrationWebhook, typeof(global::ElevenLabs.ApiIntegrationWebhookToolConfigInput), options);
            }
            else if (value.IsSmb)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Smb, typeof(global::ElevenLabs.SMBToolConfig), options);
            }
        }
    }
}