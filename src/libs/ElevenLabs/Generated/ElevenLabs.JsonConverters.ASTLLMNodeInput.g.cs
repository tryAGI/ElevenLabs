#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ASTLLMNodeInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ASTLLMNodeInput>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ASTLLMNodeInput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::ElevenLabs.ASTLLMNodeInputASTLLMNode? aSTLLMNode1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInputASTLLMNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode).Name}");
                aSTLLMNode1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::ElevenLabs.ASTLLMNodeInputASTLLMNode2? aSTLLMNode2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2).Name}");
                aSTLLMNode2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::ElevenLabs.ASTLLMNodeInput(
                aSTLLMNode1,

                aSTLLMNode2
                );

            if (aSTLLMNode1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInputASTLLMNode> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (aSTLLMNode2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ASTLLMNodeInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsASTLLMNode1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInputASTLLMNode?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ASTLLMNode1, typeInfo);
            }
            else if (value.IsASTLLMNode2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ASTLLMNode2, typeInfo);
            }
        }
    }
}