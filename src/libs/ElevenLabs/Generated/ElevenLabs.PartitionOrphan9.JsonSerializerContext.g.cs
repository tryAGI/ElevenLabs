
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan9SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_1D565FB94A852E88.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_10A53CF71F06EEEC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_699F4B1AE4AB9140.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_43692503E9D65B96.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5679C2FA775D9FF5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4594B930FF4B237A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4DF5FC7246689E2D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C1DD8340B0A35B0F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_431823921439B19F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2A3838EE2A4F0EF2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7B249BCFD8514C2B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D03C25C42CA01523.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6EBEA1CAB1C0F9FE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0D842A011030622D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_16D70ACA0D58A95C.MetadataScope,                    static () => global::ElevenLabs.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan9SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan9SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan9SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization), static () => new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToSpeechFullApplyTextNormalization?), static () => new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullApplyTextNormalizationNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization), static () => new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToSpeechFullWithTimestampsApplyTextNormalization?), static () => new global::ElevenLabs.JsonConverters.BodyTextToSpeechFullWithTimestampsApplyTextNormalizationNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization), static () => new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToSpeechStreamApplyTextNormalization?), static () => new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamApplyTextNormalizationNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization), static () => new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToSpeechStreamWithTimestampsApplyTextNormalization?), static () => new global::ElevenLabs.JsonConverters.BodyTextToSpeechStreamWithTimestampsApplyTextNormalizationNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.TextToSpeechFullOutputFormat), static () => new global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.TextToSpeechFullOutputFormat?), static () => new global::ElevenLabs.JsonConverters.TextToSpeechFullOutputFormatNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat), static () => new global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.TextToSpeechFullWithTimestampsOutputFormat?), static () => new global::ElevenLabs.JsonConverters.TextToSpeechFullWithTimestampsOutputFormatNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.TextToSpeechStreamOutputFormat), static () => new global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.TextToSpeechStreamOutputFormat?), static () => new global::ElevenLabs.JsonConverters.TextToSpeechStreamOutputFormatNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat), static () => new global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.TextToSpeechStreamWithTimestampsOutputFormat?), static () => new global::ElevenLabs.JsonConverters.TextToSpeechStreamWithTimestampsOutputFormatNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}