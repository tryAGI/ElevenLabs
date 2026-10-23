
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_808B96D0442D5C36
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_448B0E083E5AE2A2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5A2E156C766ABA77.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_65A9230AD843A6AE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_69C4D66AB648590D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_78C7F7B83A7154CB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_96310DBF3D0BEDAF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AA41CA108FF1DE70.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B8BFD4CCE49663BF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B9B2FD2544051168.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CDFA8CF2D314FCBE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EF9489DB0C8D46B5.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.TemplateOutputJsonConverter>(static () => new global::ElevenLabs.JsonConverters.TemplateOutputJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.TemplateArrayOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0219.Create_TemplateArrayOutput(options);
                }
                if (type == typeof(global::ElevenLabs.TemplateObjectOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0220.Create_TemplateObjectOutput(options);
                }
                if (type == typeof(global::ElevenLabs.TemplateOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0220.Create_TemplateOutput2(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateOutput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0179.Create_SourceGenerationContextMetadataType_4A3D90ED4C34DCD4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TemplateOutput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0172.Create_SourceGenerationContextMetadataType_2ACC4D87341A8030(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.TemplateOutput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0175.Create_SourceGenerationContextMetadataType_3C3B4FD9850DDFF2(options);
                }
                if (type == typeof(global::ElevenLabs.TemplateOutput?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0129.Create_NullableTemplateOutput2(options);
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