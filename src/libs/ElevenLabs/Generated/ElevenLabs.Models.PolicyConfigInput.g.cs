
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PolicyConfigInput
    {
        /// <summary>
        /// IANA timezone the calling periods are read in.<br/>
        /// Default Value: UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry")]
        public global::ElevenLabs.RetryPolicy? Retry { get; set; }

        /// <summary>
        /// The weekly windows calls may be placed in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calling_periods")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.CallingPeriod>? CallingPeriods { get; set; }

        /// <summary>
        /// The agent's data collection items that steer follow-up calls. Each defaults<br/>
        /// to the built-in item for its purpose; `null` turns it off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_collection")]
        public global::ElevenLabs.DataCollectionConfig? DataCollection { get; set; }

        /// <summary>
        /// Which `campaign__` dynamic variables follow-up calls get.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followup_context")]
        public global::ElevenLabs.FollowupContextPolicy? FollowupContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyConfigInput" /> class.
        /// </summary>
        /// <param name="timezone">
        /// IANA timezone the calling periods are read in.<br/>
        /// Default Value: UTC
        /// </param>
        /// <param name="retry"></param>
        /// <param name="callingPeriods">
        /// The weekly windows calls may be placed in.
        /// </param>
        /// <param name="dataCollection">
        /// The agent's data collection items that steer follow-up calls. Each defaults<br/>
        /// to the built-in item for its purpose; `null` turns it off.
        /// </param>
        /// <param name="followupContext">
        /// Which `campaign__` dynamic variables follow-up calls get.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PolicyConfigInput(
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
        /// Initializes a new instance of the <see cref="PolicyConfigInput" /> class.
        /// </summary>
        public PolicyConfigInput()
        {
        }

    }
}