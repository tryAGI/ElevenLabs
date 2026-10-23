
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan3SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_82DDB5F7AC27328C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CF51F6C19FE98E20.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7060F9D7A6AA03A1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_46C9AF75109A664F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DCBB27CAC0BA7B94.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C6CC4F838648B175.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_BFA7368BA14CA4FB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8B4DF86ECCDA90DF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DB1D804D6117CC00.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_16D70ACA0D58A95C.MetadataScope,                    static () => global::ElevenLabs.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan3SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan3SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan3SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus), static () => new global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.AudioNativeProjectSettingsResponseModelStatus?), static () => new global::ElevenLabs.JsonConverters.AudioNativeProjectSettingsResponseModelStatusNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization), static () => new global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalizationJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalization?), static () => new global::ElevenLabs.JsonConverters.BodyCreatesAudioNativeEnabledProjectV1AudioNativePostApplyTextNormalizationNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}