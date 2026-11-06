
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateMemberUsageLimitRequestModel
    {
        /// <summary>
        /// Monthly credit usage limit for the member. Set to null to remove the limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_limit")]
        public int? UsageLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMemberUsageLimitRequestModel" /> class.
        /// </summary>
        /// <param name="usageLimit">
        /// Monthly credit usage limit for the member. Set to null to remove the limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMemberUsageLimitRequestModel(
            int? usageLimit)
        {
            this.UsageLimit = usageLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMemberUsageLimitRequestModel" /> class.
        /// </summary>
        public UpdateMemberUsageLimitRequestModel()
        {
        }

    }
}