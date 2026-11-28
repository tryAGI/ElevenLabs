
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"identity_id":"auid_01k6m3w9xq4f2c8t7n5b0r1d2e","user_id":"ausr_01k6m3w9xq4f2c8t7n5b0r1d2e"}
    /// </summary>
    public sealed partial class FindAgentsUserByIdentityResponseModel
    {
        /// <summary>
        /// ID of the end user the identity belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// ID of the identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdentityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindAgentsUserByIdentityResponseModel" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the end user the identity belongs to.
        /// </param>
        /// <param name="identityId">
        /// ID of the identity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindAgentsUserByIdentityResponseModel(
            string userId,
            string identityId)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.IdentityId = identityId ?? throw new global::System.ArgumentNullException(nameof(identityId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindAgentsUserByIdentityResponseModel" /> class.
        /// </summary>
        public FindAgentsUserByIdentityResponseModel()
        {
        }

    }
}