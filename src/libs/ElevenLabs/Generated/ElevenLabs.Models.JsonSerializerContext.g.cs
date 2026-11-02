
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class ModelsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_1B1FC758AA7AF647.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A05A78A372F28723.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E4816358DF666EED.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_71DD4ABBE78F76D8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_763C98C04204663B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_60735FC2FF3A16DB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6C585D79FE0383D3.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_36C52F7948CC861A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A0BFAF4D5A4FC00B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7EE44DAED9B5C036.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B1C55A7233C619C1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B6638C06B9C61422.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_977B96B4C6155080.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_051FD3B8346C2E8A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1529EFD16EE828A2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7C6D68F116EA980F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2764FE788BB9809C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5E645B2D0C5B3A27.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_579254FD6682C053.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5A9B172050A01EF6.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1B2DA42605221800.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_17E49A1687929074.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2128BC26872AC43F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_09C42B8ECDCB9B30.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4EB5AEFD6374A584.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A1664DC33CF650FC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_79A5F54982E107E6.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DE72E2C397925EBC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_095C83F4AAA3F219.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1904BBA7D5C835D6.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_823FFA45AE5E9CA1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C0A82B3D6A6BAE47.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_685767F64C1D80E2.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly ModelsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static ModelsSourceGenerationContext Default => DefaultHolder.Instance;
        private ModelsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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