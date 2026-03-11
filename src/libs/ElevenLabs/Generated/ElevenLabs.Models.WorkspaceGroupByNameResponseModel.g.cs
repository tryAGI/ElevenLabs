
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"id":"1234567890","members_emails":["john.doe@example.com","jane.smith@example.com"],"name":"My Workspace Group"}
    /// </summary>
    public sealed partial class WorkspaceGroupByNameResponseModel
    {
        /// <summary>
        /// The name of the workspace group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The ID of the workspace group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The emails of the members of the workspace group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<string> MembersEmails { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceGroupByNameResponseModel" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the workspace group.
        /// </param>
        /// <param name="id">
        /// The ID of the workspace group.
        /// </param>
        /// <param name="membersEmails">
        /// The emails of the members of the workspace group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceGroupByNameResponseModel(
            string name,
            string id,
            global::System.Collections.Generic.IList<string> membersEmails)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MembersEmails = membersEmails ?? throw new global::System.ArgumentNullException(nameof(membersEmails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceGroupByNameResponseModel" /> class.
        /// </summary>
        public WorkspaceGroupByNameResponseModel()
        {
        }
    }
}