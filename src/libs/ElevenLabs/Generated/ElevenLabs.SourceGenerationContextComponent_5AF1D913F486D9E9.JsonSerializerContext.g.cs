
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_5AF1D913F486D9E9
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_812B9DEDFB4B2B26.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DAFAF32A885F01AF.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UserEvaluationAnalysisItem, global::ElevenLabs.UserDataCollectionAnalysisItemInput>>(static () => new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.UserEvaluationAnalysisItem, global::ElevenLabs.UserDataCollectionAnalysisItemInput>());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.UserEvaluationAnalysisItem, global::ElevenLabs.UserDataCollectionAnalysisItemInput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0202.Create_SourceGenerationContextMetadataType_5AF1D913F486D9E9(options);
                }
                if (type == typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.UserEvaluationAnalysisItem, global::ElevenLabs.UserDataCollectionAnalysisItemInput>?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0204.Create_SourceGenerationContextMetadataType_6738344D90099585(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}