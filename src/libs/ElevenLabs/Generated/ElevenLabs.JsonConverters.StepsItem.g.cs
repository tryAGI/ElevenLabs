#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class StepsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.StepsItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.StepsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.WorkflowToolEdgeStepModel? edge = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType.Edge)
            {
                edge = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowToolEdgeStepModel>(ref reader, options);
            }
            global::ElevenLabs.WorkflowToolNestedToolsStepModelInput? nestedTools = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType.NestedTools)
            {
                nestedTools = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowToolNestedToolsStepModelInput>(ref reader, options);
            }
            global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? maxIterationsExceeded = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType.MaxIterationsExceeded)
            {
                maxIterationsExceeded = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel>(ref reader, options);
            }

            var __value = new global::ElevenLabs.StepsItem(
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
            global::ElevenLabs.StepsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsEdge)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Edge, typeof(global::ElevenLabs.WorkflowToolEdgeStepModel), options);
            }
            else if (value.IsNestedTools)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NestedTools, typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput), options);
            }
            else if (value.IsMaxIterationsExceeded)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxIterationsExceeded, typeof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel), options);
            }
        }
    }
}