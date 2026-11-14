
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Each section set here replaces the whole matching section of the policy.
    /// </summary>
    public sealed partial class AgentPolicyOverrideInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry")]
        public global::ElevenLabs.RetryPolicy? Retry { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calling_periods")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallingPeriod>? CallingPeriods { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        public global::ElevenLabs.DataCollectionConfig? DataCollection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followup_context")]
        public global::ElevenLabs.FollowupContextPolicy? FollowupContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPolicyOverrideInput" /> class.
        /// </summary>
        /// <param name="timezone"></param>
        /// <param name="retry"></param>
        /// <param name="callingPeriods"></param>
        /// <param name="dataCollection"></param>
        /// <param name="followupContext"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPolicyOverrideInput(
            string? timezone,
            global::ElevenLabs.RetryPolicy? retry,
            global::System.Collections.Generic.IList<global::ElevenLabs.CallingPeriod>? callingPeriods,
            global::ElevenLabs.DataCollectionConfig? dataCollection,
            global::ElevenLabs.FollowupContextPolicy? followupContext)
        {
            this.Timezone = timezone;
            this.Retry = retry;
            this.CallingPeriods = callingPeriods;
            this.DataCollection = dataCollection;
            this.FollowupContext = followupContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPolicyOverrideInput" /> class.
        /// </summary>
        public AgentPolicyOverrideInput()
        {
        }

    }
}