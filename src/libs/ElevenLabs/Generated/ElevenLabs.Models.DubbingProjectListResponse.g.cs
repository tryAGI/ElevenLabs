
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingProjectListResponse
    {
        /// <summary>
        /// The page of dubbing projects the caller can access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.DubbingProjectResponse> Projects { get; set; }

        /// <summary>
        /// Cursor for the next page, or null when there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingProjectListResponse" /> class.
        /// </summary>
        /// <param name="projects">
        /// The page of dubbing projects the caller can access.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor for the next page, or null when there are no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingProjectListResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.DubbingProjectResponse> projects,
            string? nextCursor)
        {
            this.Projects = projects ?? throw new global::System.ArgumentNullException(nameof(projects));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingProjectListResponse" /> class.
        /// </summary>
        public DubbingProjectListResponse()
        {
        }

    }
}