#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Right3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Right3>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Right3 Read(
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
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            if (__jsonProps.Contains("name")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("type")) __score5++;
            if (__jsonProps.Contains("children")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("type")) __score6++;
            if (__jsonProps.Contains("children")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("type")) __score7++;
            if (__jsonProps.Contains("left")) __score7++;
            if (__jsonProps.Contains("right")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("type")) __score8++;
            if (__jsonProps.Contains("left")) __score8++;
            if (__jsonProps.Contains("right")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("type")) __score9++;
            if (__jsonProps.Contains("left")) __score9++;
            if (__jsonProps.Contains("right")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("type")) __score10++;
            if (__jsonProps.Contains("left")) __score10++;
            if (__jsonProps.Contains("right")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("type")) __score11++;
            if (__jsonProps.Contains("left")) __score11++;
            if (__jsonProps.Contains("right")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("type")) __score12++;
            if (__jsonProps.Contains("left")) __score12++;
            if (__jsonProps.Contains("right")) __score12++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }
            if (__score10 > __bestScore) { __bestScore = __score10; __bestIndex = 10; }
            if (__score11 > __bestScore) { __bestScore = __score11; __bestIndex = 11; }
            if (__score12 > __bestScore) { __bestScore = __score12; __bestIndex = 12; }

            global::ElevenLabs.ASTStringNodeInput? stringLiteral = default;
            global::ElevenLabs.ASTNumberNodeInput? numberLiteral = default;
            global::ElevenLabs.ASTBooleanNodeInput? booleanLiteral = default;
            global::ElevenLabs.ASTLLMNodeInput? aSTLMNodeInput = default;
            global::ElevenLabs.ASTDynamicVariableNodeInput? dynamicVariable = default;
            global::ElevenLabs.ASTOrOperatorNodeInput? orOperator = default;
            global::ElevenLabs.ASTAndOperatorNodeInput? andOperator = default;
            global::ElevenLabs.ASTEqualsOperatorNodeInput? eqOperator = default;
            global::ElevenLabs.ASTNotEqualsOperatorNodeInput? neqOperator = default;
            global::ElevenLabs.ASTGreaterThanOperatorNodeInput? gtOperator = default;
            global::ElevenLabs.ASTLessThanOperatorNodeInput? ltOperator = default;
            global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? gteOperator = default;
            global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? lteOperator = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTStringNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTStringNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTStringNodeInput).Name}");
                        stringLiteral = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNumberNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNumberNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTNumberNodeInput).Name}");
                        numberLiteral = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTBooleanNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTBooleanNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTBooleanNodeInput).Name}");
                        booleanLiteral = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInput).Name}");
                        aSTLMNodeInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTDynamicVariableNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTDynamicVariableNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTDynamicVariableNodeInput).Name}");
                        dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTOrOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTOrOperatorNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTOrOperatorNodeInput).Name}");
                        orOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTAndOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTAndOperatorNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTAndOperatorNodeInput).Name}");
                        andOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTEqualsOperatorNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput).Name}");
                        eqOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNotEqualsOperatorNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput).Name}");
                        neqOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOperatorNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput).Name}");
                        gtOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 10)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOperatorNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput).Name}");
                        ltOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 11)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput).Name}");
                        gteOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 12)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput).Name}");
                        lteOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (stringLiteral == null && numberLiteral == null && booleanLiteral == null && aSTLMNodeInput == null && dynamicVariable == null && orOperator == null && andOperator == null && eqOperator == null && neqOperator == null && gtOperator == null && ltOperator == null && gteOperator == null && lteOperator == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTStringNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTStringNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTStringNodeInput).Name}");
                    stringLiteral = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNumberNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNumberNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTNumberNodeInput).Name}");
                    numberLiteral = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTBooleanNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTBooleanNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTBooleanNodeInput).Name}");
                    booleanLiteral = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInput).Name}");
                    aSTLMNodeInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTDynamicVariableNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTDynamicVariableNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTDynamicVariableNodeInput).Name}");
                    dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTOrOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTOrOperatorNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTOrOperatorNodeInput).Name}");
                    orOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTAndOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTAndOperatorNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTAndOperatorNodeInput).Name}");
                    andOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTEqualsOperatorNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput).Name}");
                    eqOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNotEqualsOperatorNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput).Name}");
                    neqOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOperatorNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput).Name}");
                    gtOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOperatorNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput).Name}");
                    ltOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput).Name}");
                    gteOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput).Name}");
                    lteOperator = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::ElevenLabs.Right3(
                stringLiteral,

                numberLiteral,

                booleanLiteral,

                aSTLMNodeInput,

                dynamicVariable,

                orOperator,

                andOperator,

                eqOperator,

                neqOperator,

                gtOperator,

                ltOperator,

                gteOperator,

                lteOperator
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Right3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTStringNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTStringNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTStringNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringLiteral, typeInfo);
            }
            else if (value.IsNumberLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNumberNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNumberNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTNumberNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumberLiteral, typeInfo);
            }
            else if (value.IsBooleanLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTBooleanNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTBooleanNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTBooleanNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BooleanLiteral, typeInfo);
            }
            else if (value.IsASTLMNodeInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ASTLMNodeInput, typeInfo);
            }
            else if (value.IsDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTDynamicVariableNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTDynamicVariableNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTDynamicVariableNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable, typeInfo);
            }
            else if (value.IsOrOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTOrOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTOrOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTOrOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrOperator, typeInfo);
            }
            else if (value.IsAndOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTAndOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTAndOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTAndOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AndOperator, typeInfo);
            }
            else if (value.IsEqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EqOperator, typeInfo);
            }
            else if (value.IsNeqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNotEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NeqOperator, typeInfo);
            }
            else if (value.IsGtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GtOperator, typeInfo);
            }
            else if (value.IsLtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LtOperator, typeInfo);
            }
            else if (value.IsGteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GteOperator, typeInfo);
            }
            else if (value.IsLteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LteOperator, typeInfo);
            }
        }
    }
}