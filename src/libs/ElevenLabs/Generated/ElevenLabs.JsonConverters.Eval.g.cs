#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class EvalJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Eval>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Eval Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.LLMParameterEvaluationStrategy? llm = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.LLMParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.LLMParameterEvaluationStrategy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.LLMParameterEvaluationStrategy)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.RegexParameterEvaluationStrategy? regex = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType.Regex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.RegexParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.RegexParameterEvaluationStrategy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.RegexParameterEvaluationStrategy)}");
                regex = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ExactParameterEvaluationStrategy? exact = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType.Exact)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ExactParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ExactParameterEvaluationStrategy> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ExactParameterEvaluationStrategy)}");
                exact = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.Eval(
                discriminator?.Type,
                llm,
                regex,
                exact
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Eval value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.LLMParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.LLMParameterEvaluationStrategy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.LLMParameterEvaluationStrategy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeInfo);
            }
            else if (value.IsRegex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.RegexParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.RegexParameterEvaluationStrategy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.RegexParameterEvaluationStrategy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Regex, typeInfo);
            }
            else if (value.IsExact)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ExactParameterEvaluationStrategy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ExactParameterEvaluationStrategy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ExactParameterEvaluationStrategy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Exact, typeInfo);
            }
        }
    }
}