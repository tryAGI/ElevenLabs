#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class EvaluationCriteriaItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.EvaluationCriteriaItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.EvaluationCriteriaItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.AttachedUserEvaluationRef? user = default;
            if (discriminator?.Source == global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource.User)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AttachedUserEvaluationRef), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AttachedUserEvaluationRef> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AttachedUserEvaluationRef)}");
                user = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.AttachedSystemEvaluationRef? system = default;
            if (discriminator?.Source == global::ElevenLabs.AgentAnalysisItemsInputEvaluationCriteriaItemDiscriminatorSource.System)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AttachedSystemEvaluationRef), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AttachedSystemEvaluationRef> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AttachedSystemEvaluationRef)}");
                system = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.EvaluationCriteriaItem(
                discriminator?.Source,
                user,

                system
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.EvaluationCriteriaItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUser)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AttachedUserEvaluationRef), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AttachedUserEvaluationRef?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AttachedUserEvaluationRef).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.User!, typeInfo);
            }
            else if (value.IsSystem)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AttachedSystemEvaluationRef), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AttachedSystemEvaluationRef?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.AttachedSystemEvaluationRef).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.System!, typeInfo);
            }
        }
    }
}