
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationTokenResponseModel
    {
        /// <summary>
        /// The ID of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// The token for the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationToken { get; set; }

        /// <summary>
        /// The expiration time of the token in unix seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration_time_unix_secs")]
        public int? ExpirationTimeUnixSecs { get; set; }

        /// <summary>
        /// The ID of the conversation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// The purpose of the token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ConversationTokenPurposeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationTokenPurpose Purpose { get; set; }

        /// <summary>
        /// The user ID of the entity who requested the token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_requester_user_id")]
        public string? TokenRequesterUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTokenResponseModel" /> class.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent
        /// </param>
        /// <param name="conversationToken">
        /// The token for the agent
        /// </param>
        /// <param name="purpose">
        /// The purpose of the token
        /// </param>
        /// <param name="expirationTimeUnixSecs">
        /// The expiration time of the token in unix seconds
        /// </param>
        /// <param name="conversationId">
        /// The ID of the conversation
        /// </param>
        /// <param name="tokenRequesterUserId">
        /// The user ID of the entity who requested the token
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTokenResponseModel(
            string agentId,
            string conversationToken,
            global::ElevenLabs.ConversationTokenPurpose purpose,
            int? expirationTimeUnixSecs,
            string? conversationId,
            string? tokenRequesterUserId)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.ConversationToken = conversationToken ?? throw new global::System.ArgumentNullException(nameof(conversationToken));
            this.ExpirationTimeUnixSecs = expirationTimeUnixSecs;
            this.ConversationId = conversationId;
            this.Purpose = purpose;
            this.TokenRequesterUserId = tokenRequesterUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTokenResponseModel" /> class.
        /// </summary>
        public ConversationTokenResponseModel()
        {
        }

    }
}