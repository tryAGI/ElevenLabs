
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"created_by":"ar6633Es2kUjFXBdR1iVc9ztsXl1","creation_time_unix":1714156800,"description":"This is a test dictionary","id":"5xM3yVvZQKV0EfqQpLrJ","latest_version_id":"5xM3yVvZQKV0EfqQpLr2","latest_version_rules_num":2,"name":"My Dictionary","permission_on_resource":"admin"}
    /// </summary>
    public sealed partial class GetPronunciationDictionaryMetadataResponseModel
    {
        /// <summary>
        /// The ID of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the latest version of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string LatestVersionId { get; set; } = default!;

        /// <summary>
        /// The number of rules in the latest version of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version_rules_num")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int LatestVersionRulesNum { get; set; } = default!;

        /// <summary>
        /// The name of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The permission on the resource of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission_on_resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource? PermissionOnResource { get; set; } = default!;

        /// <summary>
        /// The user ID of the creator of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string CreatedBy { get; set; } = default!;

        /// <summary>
        /// The creation time of the pronunciation dictionary in Unix timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creation_time_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTimeOffset CreationTimeUnix { get; set; } = default!;

        /// <summary>
        /// The archive time of the pronunciation dictionary in Unix timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_time_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ArchivedTimeUnix { get; set; }

        /// <summary>
        /// The description of the pronunciation dictionary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionaryMetadataResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the pronunciation dictionary.
        /// </param>
        /// <param name="latestVersionId">
        /// The ID of the latest version of the pronunciation dictionary.
        /// </param>
        /// <param name="latestVersionRulesNum">
        /// The number of rules in the latest version of the pronunciation dictionary.
        /// </param>
        /// <param name="name">
        /// The name of the pronunciation dictionary.
        /// </param>
        /// <param name="permissionOnResource">
        /// The permission on the resource of the pronunciation dictionary.
        /// </param>
        /// <param name="createdBy">
        /// The user ID of the creator of the pronunciation dictionary.
        /// </param>
        /// <param name="creationTimeUnix">
        /// The creation time of the pronunciation dictionary in Unix timestamp.
        /// </param>
        /// <param name="archivedTimeUnix">
        /// The archive time of the pronunciation dictionary in Unix timestamp.
        /// </param>
        /// <param name="description">
        /// The description of the pronunciation dictionary.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPronunciationDictionaryMetadataResponseModel(
            string id,
            string latestVersionId,
            int latestVersionRulesNum,
            string name,
            global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource? permissionOnResource,
            string createdBy,
            global::System.DateTimeOffset creationTimeUnix,
            global::System.DateTimeOffset? archivedTimeUnix,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LatestVersionId = latestVersionId ?? throw new global::System.ArgumentNullException(nameof(latestVersionId));
            this.LatestVersionRulesNum = latestVersionRulesNum;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PermissionOnResource = permissionOnResource;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreationTimeUnix = creationTimeUnix;
            this.ArchivedTimeUnix = archivedTimeUnix;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPronunciationDictionaryMetadataResponseModel" /> class.
        /// </summary>
        public GetPronunciationDictionaryMetadataResponseModel()
        {
        }
    }
}