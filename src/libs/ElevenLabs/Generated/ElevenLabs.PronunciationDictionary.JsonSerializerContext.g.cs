
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PronunciationDictionarySourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_F9A22F1C94CDA8C7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3D00167CB7B960EE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A05A78A372F28723.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A2CECEB7EC6E42B8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1911F4A14CD926DB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3231F4976AB85B58.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0D080C0F68D346C2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E414812DB5AFCD17.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_425048A2428E0EED.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3F0D872B1DD5A577.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_575B77550B597DD5.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PronunciationDictionarySourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PronunciationDictionarySourceGenerationContext Default => DefaultHolder.Instance;
        private PronunciationDictionarySourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

    }
}