
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Platform limit with usage computed externally. Example: PVCs use the count_owned_pro_voices_in_billing_group function to compute the usage.
    /// </summary>
    public sealed partial class ComputedUsagePlatformLimit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputedUsagePlatformLimit" /> class.
        /// </summary>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputedUsagePlatformLimit(
            int? limit)
        {
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputedUsagePlatformLimit" /> class.
        /// </summary>
        public ComputedUsagePlatformLimit()
        {
        }

    }
}