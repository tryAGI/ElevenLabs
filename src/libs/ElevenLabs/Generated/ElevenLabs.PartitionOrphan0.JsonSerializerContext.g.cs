
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan0SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_9D9B19F925C0EA83.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D28139115C06A6C5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_350C73119E935147.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AF525BC955473331.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5CF17D5D5D9281A2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AE3727D72D423F35.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1904BBA7D5C835D6.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8D1765A8FBCEEA30.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8D236AE36FF4E709.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_147049BAB8B0A70F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0A4920DF4AB9D36C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_16D70ACA0D58A95C.MetadataScope,                    static () => global::ElevenLabs.PartitionCoreSourceGenerationContext.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan0SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan0SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan0SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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