
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateCrawlJobResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: discovery
        /// </summary>
        /// <default>global::ElevenLabs.CrawlType.Discovery</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CrawlTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CrawlType Type { get; set; } = global::ElevenLabs.CrawlType.Discovery;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_folder_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RootFolderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The folder path segments leading to the root folder, from root to parent folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_path")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel>? FolderPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCrawlJobResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type">
        /// Default Value: discovery
        /// </param>
        /// <param name="rootFolderId"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="folderPath">
        /// The folder path segments leading to the root folder, from root to parent folder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCrawlJobResponseModel(
            string id,
            global::ElevenLabs.CrawlType type,
            string rootFolderId,
            string status,
            int createdAt,
            global::System.Collections.Generic.IList<global::ElevenLabs.KnowledgeBaseFolderPathSegmentSummaryResponseModel>? folderPath)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.RootFolderId = rootFolderId ?? throw new global::System.ArgumentNullException(nameof(rootFolderId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreatedAt = createdAt;
            this.FolderPath = folderPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCrawlJobResponseModel" /> class.
        /// </summary>
        public CreateCrawlJobResponseModel()
        {
        }

    }
}