
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C2E9F8E8A5B7A2DA
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0F5FEC7459D0406A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_16C8CAC8E35F8A18.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2CB539B712324E9F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2DBC0F0FF5FB2728.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_49AFF34890AE4E0B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_68C7EE92C58C8F30.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_873F4FC03A5091FB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9A5FD39633773D83.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9C1280FB20C5B9F1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9FE6A580AB8B741E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_BDFFA52684025BA9.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C7C7B3275E9B7FF0.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DD40E26660CD63F7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EF8185DA6ED4AB8A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EFA2C5E754961B9C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F8F74800322B7013.MetadataScope,
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
                if (type == typeof(global::ElevenLabs.ConversationHistoryMetadataCommonModel))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0039.Create_ConversationHistoryMetadataCommonModel(options);
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