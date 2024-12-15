
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationTokenDBModel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_time_unix_secs")]
        public int? ExpirationTimeUnixSecs { get; set; }

        /// <summary>
        /// Default Value: signed_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeJsonConverter))]
        public global::ElevenLabs.ConversationTokenPurpose? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTokenDBModel" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="conversationToken"></param>
        /// <param name="expirationTimeUnixSecs"></param>
        /// <param name="purpose">
        /// Default Value: signed_url
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ConversationTokenDBModel(
            string agentId,
            string conversationToken,
            int? expirationTimeUnixSecs,
            global::ElevenLabs.ConversationTokenPurpose? purpose)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConversationToken = conversationToken ?? throw new global::System.ArgumentNullException(nameof(conversationToken));
            this.ExpirationTimeUnixSecs = expirationTimeUnixSecs;
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTokenDBModel" /> class.
        /// </summary>
        public ConversationTokenDBModel()
        {
        }
    }
}