
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_32974CA444762D06
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0AC9EA78B9B911CF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2B5050DE8C00B46B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3CA0DC2166398A91.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_505A5857B6CF251C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_50B00840A2AC64A8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5B74916329B79690.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6ABDCE5D8FECF107.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6B731BF1BA6AEB6C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_81A3BF490FBA3825.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D800BCA009437C7B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E656988BEF036B4E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F6863D415DAA7132.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_FC0E98920D94ED65.MetadataScope,
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
                if (type == typeof(global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0040.Create_ConversationHistoryTranscriptCommonModelOutput(options);
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