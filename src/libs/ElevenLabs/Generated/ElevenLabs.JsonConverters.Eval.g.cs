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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.LLMParameterEvaluationStrategy? llm = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.LLMParameterEvaluationStrategy>(ref reader, options);
            }
            global::ElevenLabs.RegexParameterEvaluationStrategy? regex = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType.Regex)
            {
                regex = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.RegexParameterEvaluationStrategy>(ref reader, options);
            }
            global::ElevenLabs.ExactParameterEvaluationStrategy? exact = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType.Exact)
            {
                exact = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ExactParameterEvaluationStrategy>(ref reader, options);
            }
            global::ElevenLabs.MatchAnythingParameterEvaluationStrategy? anything = default;
            if (discriminator?.Type == global::ElevenLabs.UnitTestToolCallParameterEvalDiscriminatorType.Anything)
            {
                anything = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.MatchAnythingParameterEvaluationStrategy>(ref reader, options);
            }

            var __value = new global::ElevenLabs.Eval(
                discriminator?.Type,
                llm,

                regex,

                exact,

                anything
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Eval value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::ElevenLabs.LLMParameterEvaluationStrategy), options);
            }
            else if (value.IsRegex)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Regex, typeof(global::ElevenLabs.RegexParameterEvaluationStrategy), options);
            }
            else if (value.IsExact)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Exact, typeof(global::ElevenLabs.ExactParameterEvaluationStrategy), options);
            }
            else if (value.IsAnything)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Anything, typeof(global::ElevenLabs.MatchAnythingParameterEvaluationStrategy), options);
            }
        }
    }
}