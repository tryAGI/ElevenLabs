
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An `image` output, downloaded from `content_url` once completed.
    /// </summary>
    public sealed partial class TemplateImageOutput
    {
        /// <summary>
        /// The id of the generation behind this output. Pass it as a `generation` reference to use the output as an input elsewhere.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The lifecycle status of the output. It ends at `completed`, when the output's content fields are set, or `failed`, when `failure_reason` and `error_message` are set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TemplateRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TemplateRunStatus Status { get; set; }

        /// <summary>
        /// The category of failure. Present only when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public global::ElevenLabs.TemplateImageOutputFailureReason? FailureReason { get; set; }

        /// <summary>
        /// A human-readable description of the failure. Present only when `status` is `failed`. Failed generations are not charged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// A signed URL to download the generated media from. Present only when `status` is `completed`. It expires about an hour after this response is returned; fetch the run again for a fresh URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_url")]
        public string? ContentUrl { get; set; }

        /// <summary>
        /// The MIME type of the generated media. Present only when `status` is `completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_mime_type")]
        public string? ContentMimeType { get; set; }

        /// <summary>
        /// The kind of output: the `type` of the port's `content_schema`.
        /// </summary>
        /// <default>"image"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "image";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateImageOutput" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the generation behind this output. Pass it as a `generation` reference to use the output as an input elsewhere.
        /// </param>
        /// <param name="status">
        /// The lifecycle status of the output. It ends at `completed`, when the output's content fields are set, or `failed`, when `failure_reason` and `error_message` are set.
        /// </param>
        /// <param name="failureReason">
        /// The category of failure. Present only when `status` is `failed`.
        /// </param>
        /// <param name="errorMessage">
        /// A human-readable description of the failure. Present only when `status` is `failed`. Failed generations are not charged.
        /// </param>
        /// <param name="contentUrl">
        /// A signed URL to download the generated media from. Present only when `status` is `completed`. It expires about an hour after this response is returned; fetch the run again for a fresh URL.
        /// </param>
        /// <param name="contentMimeType">
        /// The MIME type of the generated media. Present only when `status` is `completed`.
        /// </param>
        /// <param name="type">
        /// The kind of output: the `type` of the port's `content_schema`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateImageOutput(
            string id,
            global::ElevenLabs.TemplateRunStatus status,
            global::ElevenLabs.TemplateImageOutputFailureReason? failureReason,
            string? errorMessage,
            string? contentUrl,
            string? contentMimeType,
            string type = "image")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.FailureReason = failureReason;
            this.ErrorMessage = errorMessage;
            this.ContentUrl = contentUrl;
            this.ContentMimeType = contentMimeType;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateImageOutput" /> class.
        /// </summary>
        public TemplateImageOutput()
        {
        }

    }
}