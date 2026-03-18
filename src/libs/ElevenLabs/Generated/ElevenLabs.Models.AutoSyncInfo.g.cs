
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoSyncInfo
    {
        /// <summary>
        /// Maximum number of days between automatic syncs<br/>
        /// Default Value: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimum_frequency_days")]
        public int? MinimumFrequencyDays { get; set; }

        /// <summary>
        /// Whether to remove the document if the URL becomes unavailable<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_remove")]
        public bool? AutoRemove { get; set; }

        /// <summary>
        /// Number of consecutive sync failures<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consec_failures")]
        public int? ConsecFailures { get; set; }

        /// <summary>
        /// Unix timestamp for the next scheduled sync or None (in case of folders)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_refresh_by")]
        public int? NextRefreshBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSyncInfo" /> class.
        /// </summary>
        /// <param name="minimumFrequencyDays">
        /// Maximum number of days between automatic syncs<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="autoRemove">
        /// Whether to remove the document if the URL becomes unavailable<br/>
        /// Default Value: false
        /// </param>
        /// <param name="consecFailures">
        /// Number of consecutive sync failures<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="nextRefreshBy">
        /// Unix timestamp for the next scheduled sync or None (in case of folders)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoSyncInfo(
            int? minimumFrequencyDays,
            bool? autoRemove,
            int? consecFailures,
            int? nextRefreshBy)
        {
            this.MinimumFrequencyDays = minimumFrequencyDays;
            this.AutoRemove = autoRemove;
            this.ConsecFailures = consecFailures;
            this.NextRefreshBy = nextRefreshBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoSyncInfo" /> class.
        /// </summary>
        public AutoSyncInfo()
        {
        }
    }
}