#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ASTNodeOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ASTNodeOutput>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ASTNodeOutput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTNodeOutputDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.ASTStringNodeOutput? stringLiteral = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.StringLiteral)
            {
                stringLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTStringNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTNumberNodeOutput? numberLiteral = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.NumberLiteral)
            {
                numberLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTNumberNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTBooleanNodeOutput? booleanLiteral = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.BooleanLiteral)
            {
                booleanLiteral = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTBooleanNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTLLMNodeOutput? llm = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLLMNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTDynamicVariableNodeOutput? dynamicVariable = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.DynamicVariable)
            {
                dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTDynamicVariableNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTOrOperatorNodeOutput? orOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.OrOperator)
            {
                orOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTOrOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTAndOperatorNodeOutput? andOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.AndOperator)
            {
                andOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTAndOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTEqualsOperatorNodeOutput? eqOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.EqOperator)
            {
                eqOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTEqualsOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTNotEqualsOperatorNodeOutput? neqOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.NeqOperator)
            {
                neqOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTNotEqualsOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTGreaterThanOperatorNodeOutput? gtOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.GtOperator)
            {
                gtOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTGreaterThanOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTLessThanOperatorNodeOutput? ltOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.LtOperator)
            {
                ltOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLessThanOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput? gteOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.GteOperator)
            {
                gteOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput? lteOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.LteOperator)
            {
                lteOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTAdditionOperatorNodeOutput? addOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.AddOperator)
            {
                addOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTAdditionOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTSubtractionOperatorNodeOutput? subOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.SubOperator)
            {
                subOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTSubtractionOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTMultiplicationOperatorNodeOutput? mulOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.MulOperator)
            {
                mulOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTMultiplicationOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTDivisionOperatorNodeOutput? divOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.DivOperator)
            {
                divOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTDivisionOperatorNodeOutput>(ref reader, options);
            }
            global::ElevenLabs.ASTConditionalOperatorNodeOutput? conditionalOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTNodeOutputDiscriminatorType.ConditionalOperator)
            {
                conditionalOperator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ASTConditionalOperatorNodeOutput>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ASTNodeOutput(
                discriminator?.Type,
                stringLiteral,

                numberLiteral,

                booleanLiteral,

                llm,

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
            global::ElevenLabs.ASTNodeOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsStringLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringLiteral, typeof(global::ElevenLabs.ASTStringNodeOutput), options);
            }
            else if (value.IsNumberLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumberLiteral, typeof(global::ElevenLabs.ASTNumberNodeOutput), options);
            }
            else if (value.IsBooleanLiteral)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BooleanLiteral, typeof(global::ElevenLabs.ASTBooleanNodeOutput), options);
            }
            else if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::ElevenLabs.ASTLLMNodeOutput), options);
            }
            else if (value.IsDynamicVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable, typeof(global::ElevenLabs.ASTDynamicVariableNodeOutput), options);
            }
            else if (value.IsOrOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrOperator, typeof(global::ElevenLabs.ASTOrOperatorNodeOutput), options);
            }
            else if (value.IsAndOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AndOperator, typeof(global::ElevenLabs.ASTAndOperatorNodeOutput), options);
            }
            else if (value.IsEqOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EqOperator, typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutput), options);
            }
            else if (value.IsNeqOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NeqOperator, typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput), options);
            }
            else if (value.IsGtOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GtOperator, typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput), options);
            }
            else if (value.IsLtOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LtOperator, typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutput), options);
            }
            else if (value.IsGteOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GteOperator, typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput), options);
            }
            else if (value.IsLteOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LteOperator, typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput), options);
            }
            else if (value.IsAddOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AddOperator, typeof(global::ElevenLabs.ASTAdditionOperatorNodeOutput), options);
            }
            else if (value.IsSubOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SubOperator, typeof(global::ElevenLabs.ASTSubtractionOperatorNodeOutput), options);
            }
            else if (value.IsMulOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MulOperator, typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeOutput), options);
            }
            else if (value.IsDivOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DivOperator, typeof(global::ElevenLabs.ASTDivisionOperatorNodeOutput), options);
            }
            else if (value.IsConditionalOperator)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConditionalOperator, typeof(global::ElevenLabs.ASTConditionalOperatorNodeOutput), options);
            }
        }
    }
}