
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan10SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_3B2D00190CB00D76.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4ED53CF565504AE0.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_863FF5BA6DA00A7D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_02FE4B0B09206D33.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CCAE89D576D5A437.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_ACB27E86B00E03A4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_16D70ACA0D58A95C.MetadataScope,                    static () => global::ElevenLabs.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan10SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan10SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan10SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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
            collector.AddEnum(typeof(global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat), static () => new global::ElevenLabs.JsonConverters.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormatJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormat?), static () => new global::ElevenLabs.JsonConverters.BodyVoiceChangerStreamingV1VoiceChangerVoiceIdStreamPostFileFormatNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat), static () => new global::ElevenLabs.JsonConverters.BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormatJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormat?), static () => new global::ElevenLabs.JsonConverters.BodyVoiceChangerV1VoiceChangerVoiceIdPostFileFormatNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat), static () => new global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat?), static () => new global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat), static () => new global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat?), static () => new global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}