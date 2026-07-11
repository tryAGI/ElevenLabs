
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateServiceAccountV1ServiceAccountsPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// List of groups with their permission levels to share with by default. Each entry should specify a group_id and a permission_level (admin, editor, or viewer).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_sharing_groups")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupConfig>? DefaultSharingGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateServiceAccountV1ServiceAccountsPost" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="defaultSharingGroups">
        /// List of groups with their permission levels to share with by default. Each entry should specify a group_id and a permission_level (admin, editor, or viewer).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateServiceAccountV1ServiceAccountsPost(
            string name,
            global::System.Collections.Generic.IList<global::ElevenLabs.DefaultSharingGroupConfig>? defaultSharingGroups)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DefaultSharingGroups = defaultSharingGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateServiceAccountV1ServiceAccountsPost" /> class.
        /// </summary>
        public BodyCreateServiceAccountV1ServiceAccountsPost()
        {
        }

    }
}