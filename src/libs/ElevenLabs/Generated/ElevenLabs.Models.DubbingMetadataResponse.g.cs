
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"created_at":"2025-07-15T14:49:41.1490000\u002B00:00","dubbing_id":"21m00Tcm4TlvDq8ikWAM","editable":true,"media_metadata":{"content_type":"video/mp4","duration":127.5},"name":"My Dubbing Project","status":"dubbed","target_languages":["es","fr","de"]}
    /// </summary>
    public sealed partial class DubbingMetadataResponse
    {
        /// <summary>
        /// The ID of the dubbing project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubbing_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string DubbingId { get; set; } = default!;

        /// <summary>
        /// The name of the dubbing project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The status of the dubbing project. Either 'dubbed', 'dubbing' or 'failed'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Status { get; set; } = default!;

        /// <summary>
        /// The target languages of the dubbing project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_languages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<string> TargetLanguages { get; set; } = default!;

        /// <summary>
        /// Whether this dubbing project is editable in Dubbing Studio.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editable")]
        public bool? Editable { get; set; }

        /// <summary>
        /// Timestamp this dub was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_metadata")]
        public global::ElevenLabs.DubbingMediaMetadata? MediaMetadata { get; set; }

        /// <summary>
        /// Optional error message if the dubbing project failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataResponse" /> class.
        /// </summary>
        /// <param name="dubbingId">
        /// The ID of the dubbing project.
        /// </param>
        /// <param name="name">
        /// The name of the dubbing project.
        /// </param>
        /// <param name="status">
        /// The status of the dubbing project. Either 'dubbed', 'dubbing' or 'failed'.
        /// </param>
        /// <param name="targetLanguages">
        /// The target languages of the dubbing project.
        /// </param>
        /// <param name="editable">
        /// Whether this dubbing project is editable in Dubbing Studio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdAt">
        /// Timestamp this dub was created.
        /// </param>
        /// <param name="mediaMetadata"></param>
        /// <param name="error">
        /// Optional error message if the dubbing project failed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingMetadataResponse(
            string dubbingId,
            string name,
            string status,
            global::System.Collections.Generic.IList<string> targetLanguages,
            global::System.DateTime createdAt,
            bool? editable,
            global::ElevenLabs.DubbingMediaMetadata? mediaMetadata,
            string? error)
        {
            this.DubbingId = dubbingId ?? throw new global::System.ArgumentNullException(nameof(dubbingId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.CreatedAt = createdAt;
            this.Editable = editable;
            this.MediaMetadata = mediaMetadata;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataResponse" /> class.
        /// </summary>
        public DubbingMetadataResponse()
        {
        }
    }
}