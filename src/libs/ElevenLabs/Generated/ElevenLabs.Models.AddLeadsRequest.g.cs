
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddLeadsRequest
    {
        /// <summary>
        /// Who to add. A recipient whose `id` the campaign already has is skipped, so retrying a request with ids is safe. Recipients without an `id` are always added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipients")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.SubmitCampaignRecipient> Recipients { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddLeadsRequest" /> class.
        /// </summary>
        /// <param name="recipients">
        /// Who to add. A recipient whose `id` the campaign already has is skipped, so retrying a request with ids is safe. Recipients without an `id` are always added.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddLeadsRequest(
            global::System.Collections.Generic.IList<global::ElevenLabs.SubmitCampaignRecipient> recipients)
        {
            this.Recipients = recipients ?? throw new global::System.ArgumentNullException(nameof(recipients));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddLeadsRequest" /> class.
        /// </summary>
        public AddLeadsRequest()
        {
        }

    }
}