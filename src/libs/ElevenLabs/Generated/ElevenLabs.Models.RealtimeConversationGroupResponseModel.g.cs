
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeConversationGroupResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        /// Example: {"access_source":"creator","creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </summary>
        /// <example>{"access_source":"creator","creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ResourceAccessInfo AccessInfo { get; set; }

        /// <summary>
        /// How widely a group is shared, besides its owner and workspace admins (who always have access).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sharing")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.RealtimeConversationGroupSharingSummary Sharing { get; set; }

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
        /// Initializes a new instance of the <see cref="RealtimeConversationGroupResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="accessInfo">
        /// Example: {"access_source":"creator","creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </param>
        /// <param name="sharing">
        /// How widely a group is shared, besides its owner and workspace admins (who always have access).
        /// </param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeConversationGroupResponseModel(
            string id,
            string title,
            global::ElevenLabs.ResourceAccessInfo accessInfo,
            global::ElevenLabs.RealtimeConversationGroupSharingSummary sharing,
            int createdAtUnixSecs,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description;
            this.AccessInfo = accessInfo ?? throw new global::System.ArgumentNullException(nameof(accessInfo));
            this.Sharing = sharing ?? throw new global::System.ArgumentNullException(nameof(sharing));
            this.CreatedAtUnixSecs = createdAtUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeConversationGroupResponseModel" /> class.
        /// </summary>
        public RealtimeConversationGroupResponseModel()
        {
        }

    }
}