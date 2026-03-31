
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AvatarContextRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_id")]
        public string? AvatarId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_style_id")]
        public string? AvatarStyleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_name")]
        public string? AvatarName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_style_name")]
        public string? AvatarStyleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarContextRequestModel" /> class.
        /// </summary>
        /// <param name="avatarId"></param>
        /// <param name="avatarStyleId"></param>
        /// <param name="avatarName"></param>
        /// <param name="avatarStyleName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvatarContextRequestModel(
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
        /// Initializes a new instance of the <see cref="AvatarContextRequestModel" /> class.
        /// </summary>
        public AvatarContextRequestModel()
        {
        }
    }
}