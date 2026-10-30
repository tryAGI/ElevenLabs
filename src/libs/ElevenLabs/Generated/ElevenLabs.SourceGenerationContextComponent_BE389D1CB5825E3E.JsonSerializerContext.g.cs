
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_BE389D1CB5825E3E
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_41081DB1258C942F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_47F1D28C0D915D15.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_602C0E79B9F1F35B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6CC6421B5266B5B7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_969CE80532F4D03F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A040DE62D88B5103.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E19EA3F0180B08F4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E55EC6826FA049C0.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.StepsItemJsonConverter>(static () => new global::ElevenLabs.JsonConverters.StepsItemJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>(static () => new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0044.Create_ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput(options);
                }
                if (type == typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0223.Create_SourceGenerationContextMetadataType_E5D9095B3C08E227(options);
                }
                if (type == typeof(global::ElevenLabs.StepsItem))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0232.Create_StepsItem2_3(options);
                }
                if (type == typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0263.Create_WorkflowToolNestedToolsStepModelInput(options);
                }
                if (type == typeof(global::ElevenLabs.WorkflowToolResponseModelInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0263.Create_WorkflowToolResponseModelInput(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0218.Create_SourceGenerationContextMetadataType_CC04BB3786EE8167(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0226.Create_SourceGenerationContextMetadataType_F5C21C5D411F2712(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0209.Create_SourceGenerationContextMetadataType_A03BFB0FE4D93F8F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.StepsItem>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0183.Create_SourceGenerationContextMetadataType_21A7730F060FD830(options);
                }
                if (type == typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelInput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelInput>?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0202.Create_SourceGenerationContextMetadataType_803FAB4DA4B5E7B6(options);
                }
                if (type == typeof(global::ElevenLabs.StepsItem?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0133.Create_NullableStepsItem2_3(options);
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