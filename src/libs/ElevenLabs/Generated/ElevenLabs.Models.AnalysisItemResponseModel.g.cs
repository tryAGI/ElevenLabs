
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalysisItemResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.DefinitionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Definition Definition { get; set; }

        /// <summary>
        /// Example: {"access_source":"creator","creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </summary>
        /// <example>{"access_source":"creator","creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ResourceAccessInfo AccessInfo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAtUnixSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CurrentVersionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacy_source_id")]
        public string? LegacySourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisItemResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="definition"></param>
        /// <param name="accessInfo">
        /// Example: {"access_source":"creator","creator_email":"john.doe@example.com","creator_name":"John Doe","is_creator":true,"role":"admin"}
        /// </param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="updatedAtUnixSecs"></param>
        /// <param name="currentVersionId"></param>
        /// <param name="legacySourceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalysisItemResponseModel(
            string id,
            global::ElevenLabs.Definition definition,
            global::ElevenLabs.ResourceAccessInfo accessInfo,
            int createdAtUnixSecs,
            int updatedAtUnixSecs,
            string currentVersionId,
            string? legacySourceId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Definition = definition;
            this.AccessInfo = accessInfo ?? throw new global::System.ArgumentNullException(nameof(accessInfo));
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.UpdatedAtUnixSecs = updatedAtUnixSecs;
            this.CurrentVersionId = currentVersionId ?? throw new global::System.ArgumentNullException(nameof(currentVersionId));
            this.LegacySourceId = legacySourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisItemResponseModel" /> class.
        /// </summary>
        public AnalysisItemResponseModel()
        {
        }

    }
}