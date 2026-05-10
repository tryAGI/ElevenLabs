
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost
    {
        /// <summary>
        /// The name of the folder to create
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the parent folder. If not provided, the folder will be created at the root level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the folder to create
        /// </param>
        /// <param name="parentFolderId">
        /// The ID of the parent folder. If not provided, the folder will be created at the root level.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost(
            string name,
            string? parentFolderId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParentFolderId = parentFolderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost" /> class.
        /// </summary>
        public BodyCreateAgentTestFolderV1ConvaiAgentTestingFoldersPost()
        {
        }

    }
}