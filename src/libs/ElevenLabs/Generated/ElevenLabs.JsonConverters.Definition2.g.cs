#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Definition2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Definition2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Definition2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.UserEvaluationAnalysisItem? evaluation = default;
            if (discriminator?.Kind == global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminatorKind.Evaluation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UserEvaluationAnalysisItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UserEvaluationAnalysisItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UserEvaluationAnalysisItem)}");
                evaluation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.UserDataCollectionAnalysisItemOutput? dataCollection = default;
            if (discriminator?.Kind == global::ElevenLabs.AnalysisItemVersionResponseModelDefinitionDiscriminatorKind.DataCollection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UserDataCollectionAnalysisItemOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UserDataCollectionAnalysisItemOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UserDataCollectionAnalysisItemOutput)}");
                dataCollection = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.Definition2(
                discriminator?.Kind,
                evaluation,

                dataCollection
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Definition2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsEvaluation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UserEvaluationAnalysisItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UserEvaluationAnalysisItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UserEvaluationAnalysisItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickEvaluation(), typeInfo);
            }
            else if (value.IsDataCollection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UserDataCollectionAnalysisItemOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UserDataCollectionAnalysisItemOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.UserDataCollectionAnalysisItemOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickDataCollection(), typeInfo);
            }
        }
    }
}