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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.WorkflowToolEdgeStepModel? edge = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType.Edge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolEdgeStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolEdgeStepModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowToolEdgeStepModel)}");
                edge = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowToolNestedToolsStepModelInput? nestedTools = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType.NestedTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolNestedToolsStepModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput)}");
                nestedTools = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? maxIterationsExceeded = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelInputStepDiscriminatorType.MaxIterationsExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel)}");
                maxIterationsExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.StepsItem(
                discriminator?.Type,
                edge,
                nestedTools,
                maxIterationsExceeded
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.StepsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEdge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolEdgeStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolEdgeStepModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowToolEdgeStepModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Edge, typeInfo);
            }
            else if (value.IsNestedTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolNestedToolsStepModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NestedTools, typeInfo);
            }
            else if (value.IsMaxIterationsExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MaxIterationsExceeded, typeInfo);
            }
        }
    }
}