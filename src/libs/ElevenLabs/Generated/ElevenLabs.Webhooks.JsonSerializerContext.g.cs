
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class WebhooksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_454D2B97447A2C16.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A05A78A372F28723.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_38318AEBD7986894.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F069DC61C25930BE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A7D71E3A5CF4F220.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05B131E3725605CE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1AF5D3D4C878CF6C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9C3D408C448F677C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_860E9CA2CB09E163.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9A3B08EF32664403.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_FC0ACBA26C044EC8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4EC437A881ECA00C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6EB03099EE9966AB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_50CC0B4D721E025B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6C585D79FE0383D3.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_362A7BC0DFFBFA23.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A5DA3D881E2A3B06.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_83D87605BC311FFA.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_633AD86F4A02686C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DC118CB1BBB336EF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_61AF2E66E1063571.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D51441749C21EF83.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7CC1830EE07C5EC2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EB14975A5FDD0AB4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_ECDC7AF7C52BF239.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8D8D00B8FB59BA87.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0A252ABAAC7FD47A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E3FC4B6235B14E0F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8FF08948C1A3E31F.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly WebhooksSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static WebhooksSourceGenerationContext Default => DefaultHolder.Instance;
        private WebhooksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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