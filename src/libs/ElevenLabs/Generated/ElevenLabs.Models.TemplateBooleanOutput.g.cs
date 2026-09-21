
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A `boolean` output, delivered as `content` once completed.
    /// </summary>
    public sealed partial class TemplateBooleanOutput
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
        public global::ElevenLabs.TemplateBooleanOutputFailureReason? FailureReason { get; set; }

        /// <summary>
        /// A human-readable description of the failure. Present only when `status` is `failed`. Failed generations are not charged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// The kind of output: the `type` of the port's `content_schema`.
        /// </summary>
        /// <default>"boolean"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "boolean";

        /// <summary>
        /// The generated boolean. Present only when `status` is `completed`. Reserved: no template produces this kind of output yet; it is published so that templates which do can be run with the same client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public bool? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBooleanOutput" /> class.
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
        /// <param name="content">
        /// The generated boolean. Present only when `status` is `completed`. Reserved: no template produces this kind of output yet; it is published so that templates which do can be run with the same client.
        /// </param>
        /// <param name="type">
        /// The kind of output: the `type` of the port's `content_schema`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateBooleanOutput(
            string id,
            global::ElevenLabs.TemplateRunStatus status,
            global::ElevenLabs.TemplateBooleanOutputFailureReason? failureReason,
            string? errorMessage,
            bool? content,
            string type = "boolean")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.FailureReason = failureReason;
            this.ErrorMessage = errorMessage;
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateBooleanOutput" /> class.
        /// </summary>
        public TemplateBooleanOutput()
        {
        }

    }
}