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
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OpenAISessionConfigInputToolDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OpenAISessionConfigInputToolDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.OpenAISessionConfigInputToolDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.OpenAIFunctionTool? function = default;
            if (discriminator?.Type == global::ElevenLabs.OpenAISessionConfigInputToolDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OpenAIFunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OpenAIFunctionTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.OpenAIFunctionTool)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.OpenAIMCPTool? mcp = default;
            if (discriminator?.Type == global::ElevenLabs.OpenAISessionConfigInputToolDiscriminatorType.Mcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OpenAIMCPTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OpenAIMCPTool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.OpenAIMCPTool)}");
                mcp = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.ToolsItem3(
                discriminator?.Type,
                function,

                mcp
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ToolsItem3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OpenAIFunctionTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OpenAIFunctionTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.OpenAIFunctionTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFunction(), typeInfo);
            }
            else if (value.IsMcp)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OpenAIMCPTool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OpenAIMCPTool?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.OpenAIMCPTool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickMcp(), typeInfo);
            }
        }
    }
}