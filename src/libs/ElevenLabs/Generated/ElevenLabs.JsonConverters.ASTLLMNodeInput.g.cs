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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value_schema")) __score0++;
            if (__jsonProps.Contains("value_schema.description")) __score0++;
            if (__jsonProps.Contains("value_schema.enum")) __score0++;
            if (__jsonProps.Contains("value_schema.type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("prompt")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::ElevenLabs.ASTLLMNodeInputASTLLMNode? aSTLLMNode1 = default;
            global::ElevenLabs.ASTLLMNodeInputASTLLMNode2? aSTLLMNode2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInputASTLLMNode> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode).Name}");
                        aSTLLMNode1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2).Name}");
                        aSTLLMNode2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (aSTLLMNode1 == null && aSTLLMNode2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInputASTLLMNode> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode).Name}");
                    aSTLLMNode1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (aSTLLMNode1 == null && aSTLLMNode2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2).Name}");
                    aSTLLMNode2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::ElevenLabs.ASTLLMNodeInput(
                aSTLLMNode1,

                aSTLLMNode2
                );

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
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ASTLLMNode1!, typeInfo);
            }
            else if (value.IsASTLLMNode2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ASTLLMNode2!, typeInfo);
            }
        }
    }
}