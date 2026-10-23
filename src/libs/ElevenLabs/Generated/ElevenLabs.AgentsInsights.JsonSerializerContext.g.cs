
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AgentsInsightsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_3B77BA6EDA264AEF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F22D0CB62CA099B4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A05A78A372F28723.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_FC66F021C67D064C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4B24D6ECE86A5D52.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1909718D9ABE7BDE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A9638498E1711F25.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D3983D7E353B058C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6C585D79FE0383D3.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_01C87B18F7DAF90F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CB8EF567569EA34C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1EB3CDC128223190.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C25D83C477F7D046.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A7584CC2AC70BC6F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C2AF487210A089FC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4CEA021C553B1112.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_06E73F445B6ACFE7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4AAB3D895144A9F7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C5D3DBFC94759AD2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_147049BAB8B0A70F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_554FB5AA4EA2A8A6.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_95710C75414ADCDC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B8BB0849831F3AE5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AA64CF613175F46B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_65108775E29E82A7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9EAC769F89736D6B.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AgentsInsightsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AgentsInsightsSourceGenerationContext Default => DefaultHolder.Instance;
        private AgentsInsightsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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