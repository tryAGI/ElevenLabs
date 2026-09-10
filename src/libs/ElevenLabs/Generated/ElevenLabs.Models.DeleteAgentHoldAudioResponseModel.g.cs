
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteAgentHoldAudioResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAgentHoldAudioResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteAgentHoldAudioResponseModel(
            string agentId)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAgentHoldAudioResponseModel" /> class.
        /// </summary>
        public DeleteAgentHoldAudioResponseModel()
        {
        }

    }
}