
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_28449841D2422FC9
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_68C25AE6D1CF9F4C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_726BF9BD0D49983E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_788851A21F8D441B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7DF42D71E06895AD.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8B2F2140366A64AC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A2FC484C4923115D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A9C0D46C2C24531A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C084E12E4AD70625.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E2B70D428B9432E1.MetadataScope,
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
                if (type == typeof(global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0158.Create_PromptAgentAPIModelWorkflowOverrideOutput(options);
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