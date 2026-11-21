
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CampaignProgressResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("leads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.LeadsProgress Leads { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationProgress Conversations { get; set; }

        /// <summary>
        /// When the next call is due; unset when none is scheduled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_call_time_unix")]
        public int? NextCallTimeUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignProgressResponse" /> class.
        /// </summary>
        /// <param name="leads"></param>
        /// <param name="conversations"></param>
        /// <param name="nextCallTimeUnix">
        /// When the next call is due; unset when none is scheduled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignProgressResponse(
            global::ElevenLabs.LeadsProgress leads,
            global::ElevenLabs.ConversationProgress conversations,
            int? nextCallTimeUnix)
        {
            this.Leads = leads ?? throw new global::System.ArgumentNullException(nameof(leads));
            this.Conversations = conversations ?? throw new global::System.ArgumentNullException(nameof(conversations));
            this.NextCallTimeUnix = nextCallTimeUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignProgressResponse" /> class.
        /// </summary>
        public CampaignProgressResponse()
        {
        }

    }
}