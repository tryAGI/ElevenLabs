
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentLinkResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
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
        /// <param name="agentId"></param>
        /// <param name="token"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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