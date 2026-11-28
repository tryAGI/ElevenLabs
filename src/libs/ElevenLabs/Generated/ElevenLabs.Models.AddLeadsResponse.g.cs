
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddLeadsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("campaign")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CampaignResponse Campaign { get; set; }

        /// <summary>
        /// Recipients the campaign didn't have yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Added { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddLeadsResponse" /> class.
        /// </summary>
        /// <param name="campaign"></param>
        /// <param name="added">
        /// Recipients the campaign didn't have yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddLeadsResponse(
            global::ElevenLabs.CampaignResponse campaign,
            int added)
        {
            this.Campaign = campaign ?? throw new global::System.ArgumentNullException(nameof(campaign));
            this.Added = added;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddLeadsResponse" /> class.
        /// </summary>
        public AddLeadsResponse()
        {
        }

    }
}