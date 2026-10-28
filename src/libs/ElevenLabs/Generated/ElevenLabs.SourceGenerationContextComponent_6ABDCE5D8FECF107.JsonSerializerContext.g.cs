
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6ABDCE5D8FECF107
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2DB9DE502DCDB5C7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_505A5857B6CF251C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_602C0E79B9F1F35B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_969CE80532F4D03F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A040DE62D88B5103.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B9F902BD75254CDF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E55EC6826FA049C0.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E76D870B04ACE0DD.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.StepsItem2JsonConverter>(static () => new global::ElevenLabs.JsonConverters.StepsItem2JsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>(static () => new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0043.Create_ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput(options);
                }
                if (type == typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0214.Create_SourceGenerationContextMetadataType_C8126A9C9468C2E8(options);
                }
                if (type == typeof(global::ElevenLabs.StepsItem2))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0228.Create_StepsItem22(options);
                }
                if (type == typeof(global::ElevenLabs.WorkflowToolNestedToolsStepModelOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0259.Create_WorkflowToolNestedToolsStepModelOutput(options);
                }
                if (type == typeof(global::ElevenLabs.WorkflowToolResponseModelOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0260.Create_WorkflowToolResponseModelOutput(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0195.Create_SourceGenerationContextMetadataType_6B28D304AFAAF501(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.StepsItem2>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0176.Create_SourceGenerationContextMetadataType_0D15BFAF4D066F9E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0186.Create_SourceGenerationContextMetadataType_3DDF458345E65B8C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.StepsItem2>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0211.Create_SourceGenerationContextMetadataType_B9A0D3207E93602B(options);
                }
                if (type == typeof(global::ElevenLabs.OneOf<global::ElevenLabs.ConversationHistoryTranscriptOtherToolsResultCommonModel, global::ElevenLabs.ConversationHistoryTranscriptSystemToolResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptApiIntegrationWebhookToolsResultCommonModelOutput, global::ElevenLabs.ConversationHistoryTranscriptWorkflowToolsResultCommonModelOutput>?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0179.Create_SourceGenerationContextMetadataType_1D8E61C012178A5D(options);
                }
                if (type == typeof(global::ElevenLabs.StepsItem2?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0132.Create_NullableStepsItem22(options);
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