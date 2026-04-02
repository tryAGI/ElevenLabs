#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ToolConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ToolConfig>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ToolConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ToolRequestModelToolConfigDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.WebhookToolConfigInput? webhook = default;
            if (discriminator?.Type == global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType.Webhook)
            {
                webhook = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WebhookToolConfigInput>(ref reader, options);
            }
            global::ElevenLabs.ClientToolConfigInput? client = default;
            if (discriminator?.Type == global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType.Client)
            {
                client = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ClientToolConfigInput>(ref reader, options);
            }
            global::ElevenLabs.SystemToolConfigInput? system = default;
            if (discriminator?.Type == global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType.System)
            {
                system = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SystemToolConfigInput>(ref reader, options);
            }
            global::ElevenLabs.MCPToolConfigInput? mcp = default;
            if (discriminator?.Type == global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.MCPToolConfigInput>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ToolConfig(
                discriminator?.Type,
                webhook,

                client,

                system,

                mcp
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ToolConfig value,
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
        }
    }
}