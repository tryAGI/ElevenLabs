
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The policy the campaign took when it was created, laid out like a submitted `policy`.
    /// </summary>
    public sealed partial class CampaignPolicySnapshot
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.RetryPolicy Retry { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calling_periods")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.CallingPeriodPolicy> CallingPeriods { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DataCollectionPolicy DataCollection { get; set; }

        /// <summary>
        /// Which `campaign__` dynamic variables follow-up calls get.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followup_context")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.FollowupContextPolicy FollowupContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignPolicySnapshot" /> class.
        /// </summary>
        /// <param name="timezone"></param>
        /// <param name="retry"></param>
        /// <param name="callingPeriods"></param>
        /// <param name="dataCollection"></param>
        /// <param name="followupContext">
        /// Which `campaign__` dynamic variables follow-up calls get.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignPolicySnapshot(
            string timezone,
            global::ElevenLabs.RetryPolicy retry,
            global::System.Collections.Generic.IList<global::ElevenLabs.CallingPeriodPolicy> callingPeriods,
            global::ElevenLabs.DataCollectionPolicy dataCollection,
            global::ElevenLabs.FollowupContextPolicy followupContext)
        {
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
            this.Retry = retry ?? throw new global::System.ArgumentNullException(nameof(retry));
            this.CallingPeriods = callingPeriods ?? throw new global::System.ArgumentNullException(nameof(callingPeriods));
            this.DataCollection = dataCollection ?? throw new global::System.ArgumentNullException(nameof(dataCollection));
            this.FollowupContext = followupContext ?? throw new global::System.ArgumentNullException(nameof(followupContext));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignPolicySnapshot" /> class.
        /// </summary>
        public CampaignPolicySnapshot()
        {
        }

    }
}