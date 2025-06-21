#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ToolsItem3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ToolsItem3>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ToolsItem3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.WebhookToolConfigOutput? webhook = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType.Webhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WebhookToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WebhookToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WebhookToolConfigOutput)}");
                webhook = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ClientToolConfigOutput? client = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType.Client)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ClientToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ClientToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ClientToolConfigOutput)}");
                client = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SystemToolConfigOutput? system = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SystemToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SystemToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SystemToolConfigOutput)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.MCPToolConfigOutput? mcp = default;
            if (discriminator?.Type == global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MCPToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MCPToolConfigOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.MCPToolConfigOutput)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.ToolsItem3(
                discriminator?.Type,
                webhook,
                client,
                system,
                mcp
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ToolsItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebhook)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WebhookToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WebhookToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WebhookToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeInfo);
            }
            else if (value.IsClient)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ClientToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ClientToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ClientToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client, typeInfo);
            }
            else if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SystemToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SystemToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SystemToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MCPToolConfigOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MCPToolConfigOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.MCPToolConfigOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeInfo);
            }
        }
    }
}