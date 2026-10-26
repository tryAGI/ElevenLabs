
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_7CDD3FDFA20B23D3
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_01AA468362D0D6B1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2071B517E52AB427.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2E8716217BA93A9F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3697070BB2BC6245.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_573FA2DFA7111C04.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6134C535DC780ED6.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6A53A3361F3B82D2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_720F6C95860FAAA0.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A15F068FF3B982F5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B87797F4A667D99B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C8205FC3532BDA05.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C8C1DAB4E382FE54.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CD1C5FBC4F3D32D9.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EE4EA6C6CA60A774.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.UpdateAuthConnectionResponseJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UpdateAuthConnectionResponseJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.UpdateAuthConnectionResponse))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0232.Create_UpdateAuthConnectionResponse2(options);
                }
                if (type == typeof(global::ElevenLabs.UpdateAuthConnectionResponse?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0133.Create_NullableUpdateAuthConnectionResponse2(options);
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