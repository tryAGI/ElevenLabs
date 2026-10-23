
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_95710C75414ADCDC
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_016C9D44284071B1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0E4244A89DE45FD7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2958D416D08AA5A4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_394942A0051855D2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_451321830B357A4F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5F2B23DBB962984D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7105DBF7DA2B40C8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7B147CAE2709AE6A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7EB7F5A770F9B347.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_83A968B88607BE1D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_84B4131A190EC953.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A109BEB39B4B06EC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A5CD8CB59567DE4E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C8DE62D98E2FC55B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CEE70F56C7253073.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D9DE28036344AFC4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DBB55D097052D2B0.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DFE6B974DEA16272.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_FA5F9535B42BF707.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_FDADBBF83E555633.MetadataScope,
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
                if (type == typeof(global::ElevenLabs.ProjectExtendedResponseModel))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0148.Create_ProjectExtendedResponseModel(options);
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