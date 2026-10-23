
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class SpeechToText2SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_7EA0ED5A27D02833.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A05A78A372F28723.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_13E95DE8A2610B1F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_863FF5BA6DA00A7D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CCAE89D576D5A437.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_02FE4B0B09206D33.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2792C4F2317EBF40.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4940B8BF3C03853E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3B1C9EF8FD6E8377.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D62D1CFB8A3D950F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1919F56030880AA5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_343D5FBF0C24F37A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6424B5F780082177.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9F84544D0AA89C28.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2A49E3D7EC74205F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CB7AB63E1396DEAB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B02830F2AC0AC555.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8587490A0F65C7C7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7021A70D18F91891.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_FA83CADFFE24FE88.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3C8C1E3CEB664215.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_92CB2EFB6B714EAD.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3F94B7F83B522489.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4DF7FE2368D93267.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_10A53CF71F06EEEC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7B249BCFD8514C2B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_69B53F5D9444E437.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_699F4B1AE4AB9140.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SpeechToText2SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SpeechToText2SourceGenerationContext Default => DefaultHolder.Instance;
        private SpeechToText2SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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