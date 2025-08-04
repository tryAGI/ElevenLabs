
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeaturesUsageCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language_detection")]
        public global::ElevenLabs.FeatureStatusCommonModel? LanguageDetection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_agent")]
        public global::ElevenLabs.FeatureStatusCommonModel? TransferToAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_to_number")]
        public global::ElevenLabs.FeatureStatusCommonModel? TransferToNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multivoice")]
        public global::ElevenLabs.FeatureStatusCommonModel? Multivoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtmf_tones")]
        public global::ElevenLabs.FeatureStatusCommonModel? DtmfTones { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_mcp_servers")]
        public global::ElevenLabs.FeatureStatusCommonModel? ExternalMcpServers { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_zrm_workspace")]
        public bool? PiiZrmWorkspace { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pii_zrm_agent")]
        public bool? PiiZrmAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_dynamic_variable_updates")]
        public global::ElevenLabs.FeatureStatusCommonModel? ToolDynamicVariableUpdates { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_livekit")]
        public bool? IsLivekit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesUsageCommonModel" /> class.
        /// </summary>
        /// <param name="languageDetection"></param>
        /// <param name="transferToAgent"></param>
        /// <param name="transferToNumber"></param>
        /// <param name="multivoice"></param>
        /// <param name="dtmfTones"></param>
        /// <param name="externalMcpServers"></param>
        /// <param name="piiZrmWorkspace">
        /// Default Value: false
        /// </param>
        /// <param name="piiZrmAgent">
        /// Default Value: false
        /// </param>
        /// <param name="toolDynamicVariableUpdates"></param>
        /// <param name="isLivekit">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeaturesUsageCommonModel(
            global::ElevenLabs.FeatureStatusCommonModel? languageDetection,
            global::ElevenLabs.FeatureStatusCommonModel? transferToAgent,
            global::ElevenLabs.FeatureStatusCommonModel? transferToNumber,
            global::ElevenLabs.FeatureStatusCommonModel? multivoice,
            global::ElevenLabs.FeatureStatusCommonModel? dtmfTones,
            global::ElevenLabs.FeatureStatusCommonModel? externalMcpServers,
            bool? piiZrmWorkspace,
            bool? piiZrmAgent,
            global::ElevenLabs.FeatureStatusCommonModel? toolDynamicVariableUpdates,
            bool? isLivekit)
        {
            this.LanguageDetection = languageDetection;
            this.TransferToAgent = transferToAgent;
            this.TransferToNumber = transferToNumber;
            this.Multivoice = multivoice;
            this.DtmfTones = dtmfTones;
            this.ExternalMcpServers = externalMcpServers;
            this.PiiZrmWorkspace = piiZrmWorkspace;
            this.PiiZrmAgent = piiZrmAgent;
            this.ToolDynamicVariableUpdates = toolDynamicVariableUpdates;
            this.IsLivekit = isLivekit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesUsageCommonModel" /> class.
        /// </summary>
        public FeaturesUsageCommonModel()
        {
        }
    }
}