
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssignableUserResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_service_account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsServiceAccount { get; set; }

        /// <summary>
        /// Whether this workspace member currently has at least viewer access to the agent. Members without access are still returned so they can be surfaced (e.g. grayed out) and granted access before being assigned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignableUserResponseModel" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="email"></param>
        /// <param name="isServiceAccount"></param>
        /// <param name="hasAccess">
        /// Whether this workspace member currently has at least viewer access to the agent. Members without access are still returned so they can be surfaced (e.g. grayed out) and granted access before being assigned.
        /// </param>
        /// <param name="firstName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignableUserResponseModel(
            string userId,
            string email,
            bool isServiceAccount,
            bool hasAccess,
            string? firstName)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FirstName = firstName;
            this.IsServiceAccount = isServiceAccount;
            this.HasAccess = hasAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignableUserResponseModel" /> class.
        /// </summary>
        public AssignableUserResponseModel()
        {
        }

    }
}