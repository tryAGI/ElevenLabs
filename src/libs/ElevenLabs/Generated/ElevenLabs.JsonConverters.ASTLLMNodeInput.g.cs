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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value_schema")) __score0++;
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
                        aSTLLMNode1 = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLLMNodeInputASTLLMNode>(__rawJson, options);
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
                        aSTLLMNode2 = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2>(__rawJson, options);
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
                    aSTLLMNode1 = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLLMNodeInputASTLLMNode>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    aSTLLMNode2 = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2>(__rawJson, options);
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

            if (value.IsASTLLMNode1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ASTLLMNode1, typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode), options);
            }
            else if (value.IsASTLLMNode2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ASTLLMNode2, typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2), options);
            }
        }
    }
}