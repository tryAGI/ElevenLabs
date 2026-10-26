
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan8SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_E1907DF9AF706C90.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AC0787944828FEA5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7A63959D63529F29.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C391E58365991126.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8587490A0F65C7C7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B220EE0C25D2BA78.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7021A70D18F91891.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F63D8BC571D3A8A8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CB7AB63E1396DEAB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3C8C1E3CEB664215.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B50A68CE9C5701A8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0425F754D7DBB7C5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_02AF14B8E0AC0315.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9C18794E3B93B9AC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_73CEE75A5B05F534.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_16D70ACA0D58A95C.MetadataScope,                    static () => global::ElevenLabs.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan8SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan8SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan8SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization), static () => new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalization?), static () => new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceStreamingV1TextToDialogueStreamPostApplyTextNormalizationNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization), static () => new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalization?), static () => new global::ElevenLabs.JsonConverters.BodyTextToDialogueMultiVoiceV1TextToDialoguePostApplyTextNormalizationNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization), static () => new global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToDialogueFullWithTimestampsApplyTextNormalization?), static () => new global::ElevenLabs.JsonConverters.BodyTextToDialogueFullWithTimestampsApplyTextNormalizationNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization), static () => new global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyTextToDialogueStreamWithTimestampsApplyTextNormalization?), static () => new global::ElevenLabs.JsonConverters.BodyTextToDialogueStreamWithTimestampsApplyTextNormalizationNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}