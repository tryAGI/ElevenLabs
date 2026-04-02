#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ForwardConditionVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ForwardConditionVariant12>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ForwardConditionVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator>(ref readerCopy, options);

            global::ElevenLabs.WorkflowUnconditionalModelOutput? unconditional = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Unconditional)
            {
                unconditional = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowUnconditionalModelOutput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowLLMConditionModelOutput? llm = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowLLMConditionModelOutput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowResultConditionModelOutput? result = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Result)
            {
                result = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowResultConditionModelOutput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowExpressionConditionModelOutput? expression = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Expression)
            {
                expression = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowExpressionConditionModelOutput>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ForwardConditionVariant12(
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
            global::ElevenLabs.ForwardConditionVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUnconditional)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unconditional, typeof(global::ElevenLabs.WorkflowUnconditionalModelOutput), options);
            }
            else if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::ElevenLabs.WorkflowLLMConditionModelOutput), options);
            }
            else if (value.IsResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Result, typeof(global::ElevenLabs.WorkflowResultConditionModelOutput), options);
            }
            else if (value.IsExpression)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expression, typeof(global::ElevenLabs.WorkflowExpressionConditionModelOutput), options);
            }
        }
    }
}