
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An `array` output, delivered as `content` once completed: one output per<br/>
    /// element, each an output in its own right with its own `status`. A list can<br/>
    /// be arbitrarily long, so `content` is its first page; when `has_more` is<br/>
    /// true, `next_cursor` leads to the rest.
    /// </summary>
    public sealed partial class TemplateArrayOutput
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
        public global::ElevenLabs.TemplateArrayOutputFailureReason? FailureReason { get; set; }

        /// <summary>
        /// A human-readable description of the failure. Present only when `status` is `failed`. Failed generations are not charged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// The kind of output: the `type` of the port's `content_schema`.
        /// </summary>
        /// <default>"array"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "array";

        /// <summary>
        /// The first elements of the list, in order, each following the shape of the schema's `items`. Present only when `status` is `completed`. When `has_more` is true this is not the whole list. Reserved: no template produces this kind of output yet; it is published so that templates which do can be run with the same client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateOutput>? Content { get; set; }

        /// <summary>
        /// Pass as `cursor` to a later endpoint to fetch the elements after `content`. `null` when `content` holds the whole list, or before the output completes. Reserved: no template produces this kind of output yet; it is published so that templates which do can be run with the same client.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether the list has elements beyond `content`.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateArrayOutput" /> class.
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
        /// The first elements of the list, in order, each following the shape of the schema's `items`. Present only when `status` is `completed`. When `has_more` is true this is not the whole list. Reserved: no template produces this kind of output yet; it is published so that templates which do can be run with the same client.
        /// </param>
        /// <param name="nextCursor">
        /// Pass as `cursor` to a later endpoint to fetch the elements after `content`. `null` when `content` holds the whole list, or before the output completes. Reserved: no template produces this kind of output yet; it is published so that templates which do can be run with the same client.
        /// </param>
        /// <param name="type">
        /// The kind of output: the `type` of the port's `content_schema`.
        /// </param>
        /// <param name="hasMore">
        /// Whether the list has elements beyond `content`.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateArrayOutput(
            string id,
            global::ElevenLabs.TemplateRunStatus status,
            global::ElevenLabs.TemplateArrayOutputFailureReason? failureReason,
            string? errorMessage,
            global::System.Collections.Generic.IList<global::ElevenLabs.TemplateOutput>? content,
            string? nextCursor,
            string type = "array",
            bool hasMore = default!)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.FailureReason = failureReason;
            this.ErrorMessage = errorMessage;
            this.Type = type;
            this.Content = content;
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateArrayOutput" /> class.
        /// </summary>
        public TemplateArrayOutput()
        {
        }

    }
}