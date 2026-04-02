#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class StepsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.StepsItem2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.StepsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.WorkflowToolEdgeStepModel? edge = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType.Edge)
            {
                edge = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowToolEdgeStepModel>(ref reader, options);
            }
            global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput? nestedTools = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType.NestedTools)
            {
                nestedTools = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? maxIterationsExceeded = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType.MaxIterationsExceeded)
            {
                maxIterationsExceeded = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel>(ref reader, options);
            }

            var __value = new global::ElevenLabs.StepsItem2(
                discriminator?.Type,
                edge,

                nestedTools,

                maxIterationsExceeded
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.StepsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEdge)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Edge, typeof(global::ElevenLabs.WorkflowToolEdgeStepModel), options);
            }
            else if (value.IsNestedTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NestedTools, typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput), options);
            }
            else if (value.IsMaxIterationsExceeded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxIterationsExceeded, typeof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel), options);
            }
        }
    }
}