#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ASTNodeInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ASTNodeInput>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ASTNodeInput Read(
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
            if (__jsonProps.Contains("value")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("value")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("type")) __score2++;
            if (__jsonProps.Contains("value")) __score2++;
            var __score3 = 0;
            var __score4 = 0;
            if (__jsonProps.Contains("name")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("children")) __score5++;
            if (__jsonProps.Contains("type")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("children")) __score6++;
            if (__jsonProps.Contains("type")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("left")) __score7++;
            if (__jsonProps.Contains("right")) __score7++;
            if (__jsonProps.Contains("type")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("left")) __score8++;
            if (__jsonProps.Contains("right")) __score8++;
            if (__jsonProps.Contains("type")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("left")) __score9++;
            if (__jsonProps.Contains("right")) __score9++;
            if (__jsonProps.Contains("type")) __score9++;
            var __score10 = 0;
            if (__jsonProps.Contains("left")) __score10++;
            if (__jsonProps.Contains("right")) __score10++;
            if (__jsonProps.Contains("type")) __score10++;
            var __score11 = 0;
            if (__jsonProps.Contains("left")) __score11++;
            if (__jsonProps.Contains("right")) __score11++;
            if (__jsonProps.Contains("type")) __score11++;
            var __score12 = 0;
            if (__jsonProps.Contains("left")) __score12++;
            if (__jsonProps.Contains("right")) __score12++;
            if (__jsonProps.Contains("type")) __score12++;
            var __score13 = 0;
            if (__jsonProps.Contains("left")) __score13++;
            if (__jsonProps.Contains("right")) __score13++;
            if (__jsonProps.Contains("type")) __score13++;
            var __score14 = 0;
            if (__jsonProps.Contains("left")) __score14++;
            if (__jsonProps.Contains("right")) __score14++;
            if (__jsonProps.Contains("type")) __score14++;
            var __score15 = 0;
            if (__jsonProps.Contains("left")) __score15++;
            if (__jsonProps.Contains("right")) __score15++;
            if (__jsonProps.Contains("type")) __score15++;
            var __score16 = 0;
            if (__jsonProps.Contains("left")) __score16++;
            if (__jsonProps.Contains("right")) __score16++;
            if (__jsonProps.Contains("type")) __score16++;
            var __score17 = 0;
            if (__jsonProps.Contains("condition")) __score17++;
            if (__jsonProps.Contains("falseExpression")) __score17++;
            if (__jsonProps.Contains("trueExpression")) __score17++;
            if (__jsonProps.Contains("type")) __score17++;
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
            if (__score13 > __bestScore) { __bestScore = __score13; __bestIndex = 13; }
            if (__score14 > __bestScore) { __bestScore = __score14; __bestIndex = 14; }
            if (__score15 > __bestScore) { __bestScore = __score15; __bestIndex = 15; }
            if (__score16 > __bestScore) { __bestScore = __score16; __bestIndex = 16; }
            if (__score17 > __bestScore) { __bestScore = __score17; __bestIndex = 17; }

            global::ElevenLabs.ASTStringNodeInput? stringLiteral = default;
            global::ElevenLabs.ASTNumberNodeInput? numberLiteral = default;
            global::ElevenLabs.ASTBooleanNodeInput? booleanLiteral = default;
            global::ElevenLabs.ASTLLMNodeInput? lm = default;
            global::ElevenLabs.ASTDynamicVariableNodeInput? dynamicVariable = default;
            global::ElevenLabs.ASTOrOperatorNodeInput? orOperator = default;
            global::ElevenLabs.ASTAndOperatorNodeInput? andOperator = default;
            global::ElevenLabs.ASTEqualsOperatorNodeInput? eqOperator = default;
            global::ElevenLabs.ASTNotEqualsOperatorNodeInput? neqOperator = default;
            global::ElevenLabs.ASTGreaterThanOperatorNodeInput? gtOperator = default;
            global::ElevenLabs.ASTLessThanOperatorNodeInput? ltOperator = default;
            global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? gteOperator = default;
            global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? lteOperator = default;
            global::ElevenLabs.ASTAdditionOperatorNodeInput? addOperator = default;
            global::ElevenLabs.ASTSubtractionOperatorNodeInput? subOperator = default;
            global::ElevenLabs.ASTMultiplicationOperatorNodeInput? mulOperator = default;
            global::ElevenLabs.ASTDivisionOperatorNodeInput? divOperator = default;
            global::ElevenLabs.ASTConditionalOperatorNodeInput? conditionalOperator = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        stringLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTStringNodeInput>(__rawJson, options);
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
                        numberLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTNumberNodeInput>(__rawJson, options);
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
                        booleanLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTBooleanNodeInput>(__rawJson, options);
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
                        lm = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLLMNodeInput>(__rawJson, options);
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
                        dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTDynamicVariableNodeInput>(__rawJson, options);
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
                        orOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTOrOperatorNodeInput>(__rawJson, options);
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
                        andOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTAndOperatorNodeInput>(__rawJson, options);
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
                        eqOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTEqualsOperatorNodeInput>(__rawJson, options);
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
                        neqOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTNotEqualsOperatorNodeInput>(__rawJson, options);
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
                        gtOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTGreaterThanOperatorNodeInput>(__rawJson, options);
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
                        ltOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLessThanOperatorNodeInput>(__rawJson, options);
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
                        gteOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput>(__rawJson, options);
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
                        lteOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 13)
                {
                    try
                    {
                        addOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTAdditionOperatorNodeInput>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 14)
                {
                    try
                    {
                        subOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTSubtractionOperatorNodeInput>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 15)
                {
                    try
                    {
                        mulOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTMultiplicationOperatorNodeInput>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 16)
                {
                    try
                    {
                        divOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTDivisionOperatorNodeInput>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 17)
                {
                    try
                    {
                        conditionalOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTConditionalOperatorNodeInput>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (stringLiteral == null && numberLiteral == null && booleanLiteral == null && lm == null && dynamicVariable == null && orOperator == null && andOperator == null && eqOperator == null && neqOperator == null && gtOperator == null && ltOperator == null && gteOperator == null && lteOperator == null && addOperator == null && subOperator == null && mulOperator == null && divOperator == null && conditionalOperator == null)
            {
                try
                {
                    stringLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTStringNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    numberLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTNumberNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    booleanLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTBooleanNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lm = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLLMNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTDynamicVariableNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    orOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTOrOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    andOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTAndOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    eqOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTEqualsOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    neqOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTNotEqualsOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    gtOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTGreaterThanOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    ltOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLessThanOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    gteOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    lteOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    addOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTAdditionOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    subOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTSubtractionOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mulOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTMultiplicationOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    divOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTDivisionOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    conditionalOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTConditionalOperatorNodeInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::ElevenLabs.ASTNodeInput(
                stringLiteral,

                numberLiteral,

                booleanLiteral,

                lm,

                dynamicVariable,

                orOperator,

                andOperator,

                eqOperator,

                neqOperator,

                gtOperator,

                ltOperator,

                gteOperator,

                lteOperator,

                addOperator,

                subOperator,

                mulOperator,

                divOperator,

                conditionalOperator
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ASTNodeInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStringLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringLiteral, typeof(global::ElevenLabs.ASTStringNodeInput), options);
            }
            else if (value.IsNumberLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumberLiteral, typeof(global::ElevenLabs.ASTNumberNodeInput), options);
            }
            else if (value.IsBooleanLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BooleanLiteral, typeof(global::ElevenLabs.ASTBooleanNodeInput), options);
            }
            else if (value.IsLm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Lm, typeof(global::ElevenLabs.ASTLLMNodeInput), options);
            }
            else if (value.IsDynamicVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable, typeof(global::ElevenLabs.ASTDynamicVariableNodeInput), options);
            }
            else if (value.IsOrOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrOperator, typeof(global::ElevenLabs.ASTOrOperatorNodeInput), options);
            }
            else if (value.IsAndOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AndOperator, typeof(global::ElevenLabs.ASTAndOperatorNodeInput), options);
            }
            else if (value.IsEqOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EqOperator, typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput), options);
            }
            else if (value.IsNeqOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NeqOperator, typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput), options);
            }
            else if (value.IsGtOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GtOperator, typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput), options);
            }
            else if (value.IsLtOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LtOperator, typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput), options);
            }
            else if (value.IsGteOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GteOperator, typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput), options);
            }
            else if (value.IsLteOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LteOperator, typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput), options);
            }
            else if (value.IsAddOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AddOperator, typeof(global::ElevenLabs.ASTAdditionOperatorNodeInput), options);
            }
            else if (value.IsSubOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubOperator, typeof(global::ElevenLabs.ASTSubtractionOperatorNodeInput), options);
            }
            else if (value.IsMulOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MulOperator, typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeInput), options);
            }
            else if (value.IsDivOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DivOperator, typeof(global::ElevenLabs.ASTDivisionOperatorNodeInput), options);
            }
            else if (value.IsConditionalOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConditionalOperator, typeof(global::ElevenLabs.ASTConditionalOperatorNodeInput), options);
            }
        }
    }
}