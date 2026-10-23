
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class MusicSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_D824A68BE5F9A205.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A05A78A372F28723.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9D1A32D0B571AD83.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9EE4FFAE8C2D3FE5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3C1F0C5076163AB5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EAFC71A28ACB0CBB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F50EFC5A30DFEDAE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9DF230ACC90F75A5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0253F8A1BA1171CE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_99EA6A4C258FA43C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C901A973F559D8B7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D8F20C2732F3F54E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_076B2C60791454E8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0627D95D9BAD47CA.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DD26C9923A3F02BD.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_226BEF7BAA379344.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_557BB6837E6DC452.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_105089982AA262A2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_18444150DC36FA82.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3B2D00190CB00D76.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_ACB27E86B00E03A4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4ED53CF565504AE0.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0CAA026E4841A635.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C391E58365991126.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8587490A0F65C7C7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7021A70D18F91891.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_FA83CADFFE24FE88.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F63D8BC571D3A8A8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_92CB2EFB6B714EAD.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4594B930FF4B237A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6EBEA1CAB1C0F9FE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_69B53F5D9444E437.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4DF5FC7246689E2D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D99D8F665CB42262.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AABB92A1ADFB5E37.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_526B99A53BE7420C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_646B55FE7E38495E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E287161281C36F74.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly MusicSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static MusicSourceGenerationContext Default => DefaultHolder.Instance;
        private MusicSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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