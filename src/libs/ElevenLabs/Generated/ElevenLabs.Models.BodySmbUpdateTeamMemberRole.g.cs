
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodySmbUpdateTeamMemberRole
    {
        /// <summary>
        /// The member's new role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.BodySmbUpdateTeamMemberRoleRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.BodySmbUpdateTeamMemberRoleRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySmbUpdateTeamMemberRole" /> class.
        /// </summary>
        /// <param name="role">
        /// The member's new role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySmbUpdateTeamMemberRole(
            global::ElevenLabs.BodySmbUpdateTeamMemberRoleRole role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySmbUpdateTeamMemberRole" /> class.
        /// </summary>
        public BodySmbUpdateTeamMemberRole()
        {
        }

    }
}