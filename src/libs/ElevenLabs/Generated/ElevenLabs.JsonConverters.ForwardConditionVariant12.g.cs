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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.WorkflowUnconditionalModelOutput? unconditional = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Unconditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowUnconditionalModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowUnconditionalModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowUnconditionalModelOutput)}");
                unconditional = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowLLMConditionModelOutput? llm = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowLLMConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowLLMConditionModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowLLMConditionModelOutput)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowResultConditionModelOutput? result = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Result)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowResultConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowResultConditionModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowResultConditionModelOutput)}");
                result = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowExpressionConditionModelOutput? expression = default;
            if (discriminator?.Type == global::ElevenLabs.WorkflowEdgeModelOutputForwardConditionVariant1DiscriminatorType.Expression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowExpressionConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowExpressionConditionModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowExpressionConditionModelOutput)}");
                expression = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.ForwardConditionVariant12(
                discriminator?.Type,
                unconditional,
                llm,
                result,
                expression
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ForwardConditionVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUnconditional)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowUnconditionalModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowUnconditionalModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowUnconditionalModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Unconditional, typeInfo);
            }
            else if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowLLMConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowLLMConditionModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowLLMConditionModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeInfo);
            }
            else if (value.IsResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowResultConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowResultConditionModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowResultConditionModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Result, typeInfo);
            }
            else if (value.IsExpression)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowExpressionConditionModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowExpressionConditionModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowExpressionConditionModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Expression, typeInfo);
            }
        }
    }
}