
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DefaultSharingPreferencesResponseModel
    {
        /// <summary>
        /// List of groups that the user shares with by default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_sharing_groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupResponseModel> DefaultSharingGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultSharingPreferencesResponseModel" /> class.
        /// </summary>
        /// <param name="defaultSharingGroups">
        /// List of groups that the user shares with by default
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultSharingPreferencesResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceGroupResponseModel> defaultSharingGroups)
        {
            this.DefaultSharingGroups = defaultSharingGroups ?? throw new global::System.ArgumentNullException(nameof(defaultSharingGroups));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultSharingPreferencesResponseModel" /> class.
        /// </summary>
        public DefaultSharingPreferencesResponseModel()
        {
        }
    }
}