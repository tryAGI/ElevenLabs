
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostAgentHoldAudioResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// Custom hold audio played on loop to callers waiting in the agent's queue.<br/>
        /// Set by uploading a file through the agent hold-audio endpoint. Values sent in<br/>
        /// agent create or update requests are ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hold_audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AgentHoldAudioConfig HoldAudio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAgentHoldAudioResponseModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="holdAudio">
        /// Custom hold audio played on loop to callers waiting in the agent's queue.<br/>
        /// Set by uploading a file through the agent hold-audio endpoint. Values sent in<br/>
        /// agent create or update requests are ignored.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostAgentHoldAudioResponseModel(
            string agentId,
            global::ElevenLabs.AgentHoldAudioConfig holdAudio)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.HoldAudio = holdAudio ?? throw new global::System.ArgumentNullException(nameof(holdAudio));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAgentHoldAudioResponseModel" /> class.
        /// </summary>
        public PostAgentHoldAudioResponseModel()
        {
        }

    }
}