
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Platform limit with usage stored in Firestore. Example: credit usage tracked in Firestore.
    /// </summary>
    public sealed partial class StoredUsagePlatformLimit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Current usage<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public int? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoredUsagePlatformLimit" /> class.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="usage">
        /// Current usage<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoredUsagePlatformLimit(
            int? limit,
            int? usage)
        {
            this.Limit = limit;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoredUsagePlatformLimit" /> class.
        /// </summary>
        public StoredUsagePlatformLimit()
        {
        }

    }
}