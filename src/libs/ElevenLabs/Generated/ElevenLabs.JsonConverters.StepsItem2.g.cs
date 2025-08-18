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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.WorkflowToolEdgeStepModel? edge = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType.Edge)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolEdgeStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolEdgeStepModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowToolEdgeStepModel)}");
                edge = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput? nestedTools = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType.NestedTools)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput)}");
                nestedTools = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel? maxIterationsExceeded = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowToolResponseModelOutputStepDiscriminatorType.MaxIterationsExceeded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowToolMaxIterationsExceededStepModel)}");
                maxIterationsExceeded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.StepsItem2(
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
            global::ElevenLabs.StepsItem2 value,
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
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput).Name}");
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