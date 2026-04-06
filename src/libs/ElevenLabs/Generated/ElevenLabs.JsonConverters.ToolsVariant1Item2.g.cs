#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ToolsVariant1Item2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ToolsVariant1Item2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ToolsVariant1Item2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.WebhookToolConfigOutput? webhook = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WebhookToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WebhookToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WebhookToolConfigOutput)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ClientToolConfigOutput? client = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ClientToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ClientToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ClientToolConfigOutput)}");
                client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SystemToolConfigOutput? system = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SystemToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SystemToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SystemToolConfigOutput)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.MCPToolConfigOutput? mcp = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MCPToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MCPToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.MCPToolConfigOutput)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? apiIntegrationWebhook = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.ApiIntegrationWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput)}");
                apiIntegrationWebhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SMBToolConfig? smb = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutputToolsVariant1ItemDiscriminatorType.Smb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SMBToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SMBToolConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SMBToolConfig)}");
                smb = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.ToolsVariant1Item2(
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
            global::ElevenLabs.ToolsVariant1Item2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WebhookToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WebhookToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WebhookToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook!, typeInfo);
            }
            else if (value.IsClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ClientToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ClientToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ClientToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client!, typeInfo);
            }
            else if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SystemToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SystemToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SystemToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System!, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MCPToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MCPToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.MCPToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp!, typeInfo);
            }
            else if (value.IsApiIntegrationWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiIntegrationWebhook!, typeInfo);
            }
            else if (value.IsSmb)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SMBToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SMBToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SMBToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Smb!, typeInfo);
            }
        }
    }
}