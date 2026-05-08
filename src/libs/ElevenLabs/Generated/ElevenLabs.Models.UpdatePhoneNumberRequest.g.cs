
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdatePhoneNumberRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inbound_trunk_config")]
        public global::ElevenLabs.InboundSIPTrunkConfigRequestModel? InboundTrunkConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outbound_trunk_config")]
        public global::ElevenLabs.OutboundSIPTrunkConfigRequestModel? OutboundTrunkConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livekit_stack")]
        public global::ElevenLabs.LivekitStackType? LivekitStack { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_sip_messages")]
        public bool? StoreSipMessages { get; set; }

        /// <summary>
        /// Environment to use for resolving environment variables on calls to this number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Agent branch to use for calls to this number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="label"></param>
        /// <param name="inboundTrunkConfig"></param>
        /// <param name="outboundTrunkConfig"></param>
        /// <param name="livekitStack"></param>
        /// <param name="storeSipMessages"></param>
        /// <param name="environment">
        /// Environment to use for resolving environment variables on calls to this number.
        /// </param>
        /// <param name="branchId">
        /// Agent branch to use for calls to this number.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdatePhoneNumberRequest(
            string? agentId,
            string? label,
            global::ElevenLabs.InboundSIPTrunkConfigRequestModel? inboundTrunkConfig,
            global::ElevenLabs.OutboundSIPTrunkConfigRequestModel? outboundTrunkConfig,
            global::ElevenLabs.LivekitStackType? livekitStack,
            bool? storeSipMessages,
            string? environment,
            string? branchId)
        {
            this.AgentId = agentId;
            this.Label = label;
            this.InboundTrunkConfig = inboundTrunkConfig;
            this.OutboundTrunkConfig = outboundTrunkConfig;
            this.LivekitStack = livekitStack;
            this.StoreSipMessages = storeSipMessages;
            this.Environment = environment;
            this.BranchId = branchId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatePhoneNumberRequest" /> class.
        /// </summary>
        public UpdatePhoneNumberRequest()
        {
        }
    }
}