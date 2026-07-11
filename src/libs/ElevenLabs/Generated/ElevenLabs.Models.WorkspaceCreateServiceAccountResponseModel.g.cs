
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceCreateServiceAccountResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service-account-user-id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreateServiceAccountResponseModel" /> class.
        /// </summary>
        /// <param name="serviceAccountUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceCreateServiceAccountResponseModel(
            string serviceAccountUserId)
        {
            this.ServiceAccountUserId = serviceAccountUserId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountUserId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreateServiceAccountResponseModel" /> class.
        /// </summary>
        public WorkspaceCreateServiceAccountResponseModel()
        {
        }

    }
}