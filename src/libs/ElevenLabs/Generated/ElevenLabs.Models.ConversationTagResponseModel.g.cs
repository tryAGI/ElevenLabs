
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationTagResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OwnerUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTagResponseModel" /> class.
        /// </summary>
        /// <param name="tagId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="ownerUserId"></param>
        /// <param name="title"></param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationTagResponseModel(
            string tagId,
            string workspaceId,
            string ownerUserId,
            string title,
            int createdAtUnixSecs,
            string? description)
        {
            this.TagId = tagId ?? throw new global::System.ArgumentNullException(nameof(tagId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.OwnerUserId = ownerUserId ?? throw new global::System.ArgumentNullException(nameof(ownerUserId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description;
            this.CreatedAtUnixSecs = createdAtUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationTagResponseModel" /> class.
        /// </summary>
        public ConversationTagResponseModel()
        {
        }
    }
}