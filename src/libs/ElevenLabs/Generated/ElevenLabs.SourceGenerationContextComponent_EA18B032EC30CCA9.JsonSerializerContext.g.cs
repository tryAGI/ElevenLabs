
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_EA18B032EC30CCA9
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_08962F2B1EB39CBB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0C23A572F63E5E2B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0CD1E66F18E90EE1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_16C9D4B72E8E4083.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2958D416D08AA5A4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_32EF4E1342ED270C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_37CFAC8494200E96.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3C9E6B6E90BFDEB6.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_48F3D6CAA4C5BCC0.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4C00855EE029FB6D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_94C6DA13B783398A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_99DD1D7090E43505.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E318A2EE17BE2142.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.MCPServerConfigInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0088.Create_MCPServerConfigInput(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}