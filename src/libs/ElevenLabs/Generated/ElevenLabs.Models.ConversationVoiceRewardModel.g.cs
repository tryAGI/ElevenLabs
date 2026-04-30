
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationVoiceRewardModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reward_usd_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RewardUsdCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationVoiceRewardModel" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="rewardUsdCents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationVoiceRewardModel(
            string voiceId,
            double rewardUsdCents)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.RewardUsdCents = rewardUsdCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationVoiceRewardModel" /> class.
        /// </summary>
        public ConversationVoiceRewardModel()
        {
        }
    }
}