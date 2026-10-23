
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_147049BAB8B0A70F
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2C0BB17F91CF8F43.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3AB4CB0AE90ECC2B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5CF17D5D5D9281A2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_86451D82F743DCB8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9A1D78F6432C17D5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9D9B19F925C0EA83.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A6DACA59DB850FE1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AF525BC955473331.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D28139115C06A6C5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EF768EF842657185.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F33C095D1A6214E6.MetadataScope,
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
                if (type == typeof(global::ElevenLabs.SpeechEngineResponse))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0214.Create_SpeechEngineResponse(options);
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