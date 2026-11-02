
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C4D1747D2AFE56A8
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_2B25B203FAF8388B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2D161299E8E59DF4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2D9F088209E49583.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3A08D115D428096F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3C437A8858C0D6A5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_86F94A67DFDDC440.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F4B55D6A286B7613.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter>(static () => new global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.ExportOptions))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0065.Create_ExportOptions2(options);
                }
                if (type == typeof(global::ElevenLabs.ExportOptions?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0113.Create_NullableExportOptions2(options);
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