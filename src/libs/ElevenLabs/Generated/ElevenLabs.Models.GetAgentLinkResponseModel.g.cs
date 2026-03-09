
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"agent_id":"J3Pbu5gP6NNKBscdCdwB"}
    /// </summary>
    public sealed partial class GetAgentLinkResponseModel
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string AgentId { get; set; } = default!;

        /// <summary>
        /// Example: {"agent_id":"agent_J3Pbu5gP6NNKBscdCdwB","conversation_id":"conv_J3Pbu5gP6NNKBscdCdwB","conversation_token":"1234567890","expiration_time_unix_secs":1716153600,"purpose":"signed_url"}
        /// </summary>
        /// <example>{"agent_id":"agent_J3Pbu5gP6NNKBscdCdwB","conversation_id":"conv_J3Pbu5gP6NNKBscdCdwB","conversation_token":"1234567890","expiration_time_unix_secs":1716153600,"purpose":"signed_url"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public global::ElevenLabs.ConversationTokenDBModel? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentLinkResponseModel" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="token">
        /// Example: {"agent_id":"agent_J3Pbu5gP6NNKBscdCdwB","conversation_id":"conv_J3Pbu5gP6NNKBscdCdwB","conversation_token":"1234567890","expiration_time_unix_secs":1716153600,"purpose":"signed_url"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAgentLinkResponseModel(
            string agentId,
            global::ElevenLabs.ConversationTokenDBModel? token)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentLinkResponseModel" /> class.
        /// </summary>
        public GetAgentLinkResponseModel()
        {
        }
    }
}