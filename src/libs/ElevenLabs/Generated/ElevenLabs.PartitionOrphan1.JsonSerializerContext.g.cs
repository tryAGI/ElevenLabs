
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan1SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_06EB49CD1F384FD9.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DAD1A839C96D5BAD.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D16AF63172BC48AB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_BB6E8A53BD784E94.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_207FD242B1A13E6A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6E593D9BE060EDAE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5FAC0A416AD8A83F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_16D70ACA0D58A95C.MetadataScope,                    static () => global::ElevenLabs.PartitionCoreSourceGenerationContext.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan1SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan1SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan1SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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