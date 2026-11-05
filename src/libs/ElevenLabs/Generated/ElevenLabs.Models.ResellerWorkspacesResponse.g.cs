
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResellerWorkspacesResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ResellerWorkspaceSummary> Workspaces { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerWorkspacesResponse" /> class.
        /// </summary>
        /// <param name="workspaces"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResellerWorkspacesResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.ResellerWorkspaceSummary> workspaces,
            string? nextCursor,
            bool? hasMore)
        {
            this.Workspaces = workspaces ?? throw new global::System.ArgumentNullException(nameof(workspaces));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerWorkspacesResponse" /> class.
        /// </summary>
        public ResellerWorkspacesResponse()
        {
        }

    }
}