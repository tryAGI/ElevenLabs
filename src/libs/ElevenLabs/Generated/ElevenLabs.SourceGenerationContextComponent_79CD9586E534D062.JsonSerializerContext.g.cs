
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_79CD9586E534D062
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_15015BB518655F23.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_735C2AD5AA9DFF9A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_77A2EB4809B586AE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9259EE5354CB6F47.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9618ED2ED7D3678E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_BA018C80B29034E5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C40681A2442BED52.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D2D2EA6BE5D64B48.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_FED3FAA0C01E2890.MetadataScope,
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
                if (type == typeof(global::ElevenLabs.AgentConversationTicketResponseModel))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0006.Create_AgentConversationTicketResponseModel(options);
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