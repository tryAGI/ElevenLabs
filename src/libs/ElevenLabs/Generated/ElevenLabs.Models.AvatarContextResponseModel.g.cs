
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AvatarContextResponseModel
    {
        /// <summary>
        /// The ID of the avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_id")]
        public string? AvatarId { get; set; }

        /// <summary>
        /// The ID of the avatar style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_style_id")]
        public string? AvatarStyleId { get; set; }

        /// <summary>
        /// The name of the avatar.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_name")]
        public string? AvatarName { get; set; }

        /// <summary>
        /// The name of the avatar style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_style_name")]
        public string? AvatarStyleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarContextResponseModel" /> class.
        /// </summary>
        /// <param name="avatarId">
        /// The ID of the avatar.
        /// </param>
        /// <param name="avatarStyleId">
        /// The ID of the avatar style.
        /// </param>
        /// <param name="avatarName">
        /// The name of the avatar.
        /// </param>
        /// <param name="avatarStyleName">
        /// The name of the avatar style.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvatarContextResponseModel(
            string? avatarId,
            string? avatarStyleId,
            string? avatarName,
            string? avatarStyleName)
        {
            this.AvatarId = avatarId;
            this.AvatarStyleId = avatarStyleId;
            this.AvatarName = avatarName;
            this.AvatarStyleName = avatarStyleName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarContextResponseModel" /> class.
        /// </summary>
        public AvatarContextResponseModel()
        {
        }
    }
}