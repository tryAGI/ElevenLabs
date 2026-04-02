#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ToolConfig2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ToolConfig2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ToolConfig2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ToolResponseModelToolConfigDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.WebhookToolConfigOutput? webhook = default;
            if (discriminator?.Type == global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType.Webhook)
            {
                webhook = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WebhookToolConfigOutput>(ref reader, options);
            }
            global::ElevenLabs.ClientToolConfigOutput? client = default;
            if (discriminator?.Type == global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType.Client)
            {
                client = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ClientToolConfigOutput>(ref reader, options);
            }
            global::ElevenLabs.SystemToolConfigOutput? system = default;
            if (discriminator?.Type == global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType.System)
            {
                system = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SystemToolConfigOutput>(ref reader, options);
            }
            global::ElevenLabs.MCPToolConfigOutput? mcp = default;
            if (discriminator?.Type == global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType.Mcp)
            {
                mcp = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.MCPToolConfigOutput>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ToolConfig2(
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
            global::ElevenLabs.ToolConfig2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsWebhook)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Webhook, typeof(global::ElevenLabs.WebhookToolConfigOutput), options);
            }
            else if (value.IsClient)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Client, typeof(global::ElevenLabs.ClientToolConfigOutput), options);
            }
            else if (value.IsSystem)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System, typeof(global::ElevenLabs.SystemToolConfigOutput), options);
            }
            else if (value.IsMcp)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mcp, typeof(global::ElevenLabs.MCPToolConfigOutput), options);
            }
        }
    }
}