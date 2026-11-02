
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Published versions, newest first; current_version_id is the main that unpinned refs resolve to.
    /// </summary>
    public sealed partial class AnalysisItemVersionsResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemVersionResponseModel> Versions { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentVersionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisItemVersionsResponseModel" /> class.
        /// </summary>
        /// <param name="versions"></param>
        /// <param name="currentVersionId"></param>
        /// <param name="hasMore"></param>
        /// <param name="nextCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalysisItemVersionsResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemVersionResponseModel> versions,
            string currentVersionId,
            bool hasMore,
            string? nextCursor)
        {
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.CurrentVersionId = currentVersionId ?? throw new global::System.ArgumentNullException(nameof(currentVersionId));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisItemVersionsResponseModel" /> class.
        /// </summary>
        public AnalysisItemVersionsResponseModel()
        {
        }

    }
}