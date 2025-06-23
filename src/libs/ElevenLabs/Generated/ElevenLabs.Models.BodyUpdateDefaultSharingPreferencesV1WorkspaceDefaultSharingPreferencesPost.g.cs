
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateDefaultSharingPreferencesV1WorkspaceDefaultSharingPreferencesPost
    {
        /// <summary>
        /// List of group IDs to share with by default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_sharing_groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DefaultSharingGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDefaultSharingPreferencesV1WorkspaceDefaultSharingPreferencesPost" /> class.
        /// </summary>
        /// <param name="defaultSharingGroups">
        /// List of group IDs to share with by default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateDefaultSharingPreferencesV1WorkspaceDefaultSharingPreferencesPost(
            global::System.Collections.Generic.IList<string> defaultSharingGroups)
        {
            this.DefaultSharingGroups = defaultSharingGroups ?? throw new global::System.ArgumentNullException(nameof(defaultSharingGroups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateDefaultSharingPreferencesV1WorkspaceDefaultSharingPreferencesPost" /> class.
        /// </summary>
        public BodyUpdateDefaultSharingPreferencesV1WorkspaceDefaultSharingPreferencesPost()
        {
        }
    }
}