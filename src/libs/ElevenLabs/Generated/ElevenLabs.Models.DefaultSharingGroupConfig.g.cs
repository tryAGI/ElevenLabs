
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DefaultSharingGroupConfig
    {
        /// <summary>
        /// The ID of the group to share with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GroupId { get; set; }

        /// <summary>
        /// The permission level to grant to the group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.DefaultSharingGroupConfigPermissionLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel PermissionLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultSharingGroupConfig" /> class.
        /// </summary>
        /// <param name="groupId">
        /// The ID of the group to share with
        /// </param>
        /// <param name="permissionLevel">
        /// The permission level to grant to the group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DefaultSharingGroupConfig(
            string groupId,
            global::ElevenLabs.DefaultSharingGroupConfigPermissionLevel permissionLevel)
        {
            this.GroupId = groupId ?? throw new global::System.ArgumentNullException(nameof(groupId));
            this.PermissionLevel = permissionLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultSharingGroupConfig" /> class.
        /// </summary>
        public DefaultSharingGroupConfig()
        {
        }

    }
}