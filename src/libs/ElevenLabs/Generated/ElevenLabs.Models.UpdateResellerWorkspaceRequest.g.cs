
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateResellerWorkspaceRequest
    {
        /// <summary>
        /// Replaces the workspace's whole metadata map; send `{}` to clear it. Omitted leaves it unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResellerWorkspaceRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Replaces the workspace's whole metadata map; send `{}` to clear it. Omitted leaves it unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResellerWorkspaceRequest(
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResellerWorkspaceRequest" /> class.
        /// </summary>
        public UpdateResellerWorkspaceRequest()
        {
        }

    }
}