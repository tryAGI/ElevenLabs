
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan2SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_83DE60FB91C37DB9.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_226BEF7BAA379344.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_557BB6837E6DC452.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7EA0ED5A27D02833.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_13E95DE8A2610B1F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7EE44DAED9B5C036.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_360B358A831716E9.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_16D70ACA0D58A95C.MetadataScope,                    static () => global::ElevenLabs.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan2SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan2SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan2SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat), static () => new global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormatJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormat?), static () => new global::ElevenLabs.JsonConverters.BodyAudioIsolationStreamV1AudioIsolationStreamPostFileFormatNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat), static () => new global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormatJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyAudioIsolationV1AudioIsolationPostFileFormat?), static () => new global::ElevenLabs.JsonConverters.BodyAudioIsolationV1AudioIsolationPostFileFormatNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}