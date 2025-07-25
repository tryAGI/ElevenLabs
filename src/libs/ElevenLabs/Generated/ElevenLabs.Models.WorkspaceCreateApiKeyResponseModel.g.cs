
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceCreateApiKeyResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xi-api-key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string XiApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreateApiKeyResponseModel" /> class.
        /// </summary>
        /// <param name="xiApiKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceCreateApiKeyResponseModel(
            string xiApiKey)
        {
            this.XiApiKey = xiApiKey ?? throw new global::System.ArgumentNullException(nameof(xiApiKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreateApiKeyResponseModel" /> class.
        /// </summary>
        public WorkspaceCreateApiKeyResponseModel()
        {
        }
    }
}