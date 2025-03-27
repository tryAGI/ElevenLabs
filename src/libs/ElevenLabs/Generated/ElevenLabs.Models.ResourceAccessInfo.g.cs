
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceAccessInfo
    {
        /// <summary>
        /// Whether the user making the request is the creator of the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_creator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsCreator { get; set; }

        /// <summary>
        /// Name of the agent's creator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatorName { get; set; }

        /// <summary>
        /// Email of the agent's creator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatorEmail { get; set; }

        /// <summary>
        /// The role of the user making the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ResourceAccessInfoRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ResourceAccessInfoRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAccessInfo" /> class.
        /// </summary>
        /// <param name="isCreator">
        /// Whether the user making the request is the creator of the agent
        /// </param>
        /// <param name="creatorName">
        /// Name of the agent's creator
        /// </param>
        /// <param name="creatorEmail">
        /// Email of the agent's creator
        /// </param>
        /// <param name="role">
        /// The role of the user making the request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceAccessInfo(
            bool isCreator,
            string creatorName,
            string creatorEmail,
            global::ElevenLabs.ResourceAccessInfoRole role)
        {
            this.IsCreator = isCreator;
            this.CreatorName = creatorName ?? throw new global::System.ArgumentNullException(nameof(creatorName));
            this.CreatorEmail = creatorEmail ?? throw new global::System.ArgumentNullException(nameof(creatorEmail));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAccessInfo" /> class.
        /// </summary>
        public ResourceAccessInfo()
        {
        }
    }
}