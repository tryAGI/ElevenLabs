#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class BackwardConditionVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BackwardConditionVariant1>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BackwardConditionVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator>(ref readerCopy, options);

            global::ElevenLabs.WorkflowUnconditionalModelInput? unconditional = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Unconditional)
            {
                unconditional = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowUnconditionalModelInput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowLLMConditionModelInput? llm = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowLLMConditionModelInput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowResultConditionModelInput? result = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Result)
            {
                result = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowResultConditionModelInput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowExpressionConditionModelInput? expression = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Expression)
            {
                expression = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowExpressionConditionModelInput>(ref reader, options);
            }

            var __value = new global::ElevenLabs.BackwardConditionVariant1(
                discriminator?.Type,
                unconditional,

                llm,

                result,

                expression
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BackwardConditionVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUnconditional)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unconditional, typeof(global::ElevenLabs.WorkflowUnconditionalModelInput), options);
            }
            else if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::ElevenLabs.WorkflowLLMConditionModelInput), options);
            }
            else if (value.IsResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Result, typeof(global::ElevenLabs.WorkflowResultConditionModelInput), options);
            }
            else if (value.IsExpression)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expression, typeof(global::ElevenLabs.WorkflowExpressionConditionModelInput), options);
            }
        }
    }
}