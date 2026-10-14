
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserVoiceCollectionResponseModel
    {
        /// <summary>
        /// The ID of the voice collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionId { get; set; }

        /// <summary>
        /// The title of the voice collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The icon of the voice collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Icon { get; set; }

        /// <summary>
        /// The caller's access role on the voice collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_on_resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UserVoiceCollectionResponseModelPermissionOnResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.UserVoiceCollectionResponseModelPermissionOnResource PermissionOnResource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserVoiceCollectionResponseModel" /> class.
        /// </summary>
        /// <param name="collectionId">
        /// The ID of the voice collection.
        /// </param>
        /// <param name="title">
        /// The title of the voice collection.
        /// </param>
        /// <param name="icon">
        /// The icon of the voice collection.
        /// </param>
        /// <param name="permissionOnResource">
        /// The caller's access role on the voice collection.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserVoiceCollectionResponseModel(
            string collectionId,
            string title,
            string icon,
            global::ElevenLabs.UserVoiceCollectionResponseModelPermissionOnResource permissionOnResource)
        {
            this.CollectionId = collectionId ?? throw new global::System.ArgumentNullException(nameof(collectionId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Icon = icon ?? throw new global::System.ArgumentNullException(nameof(icon));
            this.PermissionOnResource = permissionOnResource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserVoiceCollectionResponseModel" /> class.
        /// </summary>
        public UserVoiceCollectionResponseModel()
        {
        }

    }
}