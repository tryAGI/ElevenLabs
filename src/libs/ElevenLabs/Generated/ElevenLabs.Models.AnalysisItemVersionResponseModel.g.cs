
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnalysisItemVersionResponseModel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("version_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.Definition2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Definition2 Definition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisItemVersionResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionNumber"></param>
        /// <param name="createdAtUnixSecs"></param>
        /// <param name="definition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalysisItemVersionResponseModel(
            string id,
            int versionNumber,
            int createdAtUnixSecs,
            global::ElevenLabs.Definition2 definition)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.VersionNumber = versionNumber;
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.Definition = definition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisItemVersionResponseModel" /> class.
        /// </summary>
        public AnalysisItemVersionResponseModel()
        {
        }

    }
}