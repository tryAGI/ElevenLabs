
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan4SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_B7A29F7F9ABF1687.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_BE28F8D25703761A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EA7A1E30380D7EED.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0E82FDD1FBE1429A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_73D5E2C7AC72E959.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B8D9F0C97918C83E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F82E221E8A6C0733.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_33300E5F6E2ABF21.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_22C30410FA1E6F1A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0BF18E305539848C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6F1D807EC85978EE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AF3385B41B932A88.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1B1BB145DC5D7E9E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_56091C1731E24296.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CE491F68841F76B3.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D8A2574218A71A16.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_BAEE593B05F125F8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8742C8C29FD1B1CC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9811ED0378920349.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3FA4594390199F23.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D535E07C5C43FCEF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1A91BDFC298D39B8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_480965C20E2F0522.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D488BDD363AEFEB8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_19BB6FAFD805D90F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5B467034C7230237.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_63E91A79D91A6D9C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_BAFAD2844911E850.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_379C4E68FEC0A7BB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_87567277702BA18D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5D17A629FD6E1217.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_16D70ACA0D58A95C.MetadataScope,                    static () => global::ElevenLabs.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan4SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan4SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan4SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode), static () => new global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode?), static () => new global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat), static () => new global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat?), static () => new global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsDubbingStatus), static () => new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsDubbingStatus?), static () => new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item), static () => new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusesVariant1ItemJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item?), static () => new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusesVariant1ItemNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item), static () => new global::ElevenLabs.JsonConverters.ListDubsDubbingModelsVariant1ItemJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item?), static () => new global::ElevenLabs.JsonConverters.ListDubsDubbingModelsVariant1ItemNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item), static () => new global::ElevenLabs.JsonConverters.ListDubsCreationSourcesVariant1ItemJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item?), static () => new global::ElevenLabs.JsonConverters.ListDubsCreationSourcesVariant1ItemNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsFilterByCreator), static () => new global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsFilterByCreator?), static () => new global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsOrderBy), static () => new global::ElevenLabs.JsonConverters.ListDubsOrderByJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsOrderBy?), static () => new global::ElevenLabs.JsonConverters.ListDubsOrderByNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsOrderDirection), static () => new global::ElevenLabs.JsonConverters.ListDubsOrderDirectionJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.ListDubsOrderDirection?), static () => new global::ElevenLabs.JsonConverters.ListDubsOrderDirectionNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType), static () => new global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType?), static () => new global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType), static () => new global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType?), static () => new global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeNullableJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.DubbingTranscriptResponseModel, string>>(static () => new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.DubbingTranscriptResponseModel, string>());
        }
        #pragma warning restore CS0612, CS0618

    }
}