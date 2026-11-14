
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CampaignFollowUpRequestsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callbacks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.FollowUpRequestCounts Callbacks { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.FollowUpRequestCounts Redirects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignFollowUpRequestsResponse" /> class.
        /// </summary>
        /// <param name="callbacks"></param>
        /// <param name="redirects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CampaignFollowUpRequestsResponse(
            global::ElevenLabs.FollowUpRequestCounts callbacks,
            global::ElevenLabs.FollowUpRequestCounts redirects)
        {
            this.Callbacks = callbacks ?? throw new global::System.ArgumentNullException(nameof(callbacks));
            this.Redirects = redirects ?? throw new global::System.ArgumentNullException(nameof(redirects));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignFollowUpRequestsResponse" /> class.
        /// </summary>
        public CampaignFollowUpRequestsResponse()
        {
        }

    }
}