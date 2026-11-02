#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ScoringJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Scoring>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Scoring Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.BinaryScoring? binary = default;
            if (discriminator?.Mode == global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminatorMode.Binary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BinaryScoring), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BinaryScoring> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BinaryScoring)}");
                binary = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.NumericUniformScoring? numericUniform = default;
            if (discriminator?.Mode == global::ElevenLabs.UserEvaluationAnalysisItemScoringDiscriminatorMode.NumericUniform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.NumericUniformScoring), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.NumericUniformScoring> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.NumericUniformScoring)}");
                numericUniform = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Scoring(
                discriminator?.Mode,
                binary,

                numericUniform
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Scoring value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsBinary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BinaryScoring), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BinaryScoring?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BinaryScoring).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBinary(), typeInfo);
            }
            else if (value.IsNumericUniform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.NumericUniformScoring), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.NumericUniformScoring?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.NumericUniformScoring).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickNumericUniform(), typeInfo);
            }
        }
    }
}