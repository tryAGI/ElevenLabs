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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.WorkflowUnconditionalModelInput? unconditional = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Unconditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowUnconditionalModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowUnconditionalModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowUnconditionalModelInput)}");
                unconditional = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowLLMConditionModelInput? llm = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowLLMConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowLLMConditionModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowLLMConditionModelInput)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowResultConditionModelInput? result = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Result)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowResultConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowResultConditionModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowResultConditionModelInput)}");
                result = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowExpressionConditionModelInput? expression = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelInputBackwardConditionVariant1DiscriminatorType.Expression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowExpressionConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowExpressionConditionModelInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowExpressionConditionModelInput)}");
                expression = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnconditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowUnconditionalModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowUnconditionalModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowUnconditionalModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unconditional!, typeInfo);
            }
            else if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowLLMConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowLLMConditionModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowLLMConditionModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm!, typeInfo);
            }
            else if (value.IsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowResultConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowResultConditionModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowResultConditionModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Result!, typeInfo);
            }
            else if (value.IsExpression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowExpressionConditionModelInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowExpressionConditionModelInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowExpressionConditionModelInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expression!, typeInfo);
            }
        }
    }
}