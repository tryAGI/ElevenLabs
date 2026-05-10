
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost
    {
        /// <summary>
        /// The IDs of tests or folders to move.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EntityIds { get; set; }

        /// <summary>
        /// The folder to move the entities to. If not set, the entities will be moved to the root folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("move_to")]
        public string? MoveTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost" /> class.
        /// </summary>
        /// <param name="entityIds">
        /// The IDs of tests or folders to move.
        /// </param>
        /// <param name="moveTo">
        /// The folder to move the entities to. If not set, the entities will be moved to the root folder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost(
            global::System.Collections.Generic.IList<string> entityIds,
            string? moveTo)
        {
            this.EntityIds = entityIds ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            this.MoveTo = moveTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost" /> class.
        /// </summary>
        public BodyBulkMoveTestsToFolderV1ConvaiAgentTestingBulkMovePost()
        {
        }

    }
}