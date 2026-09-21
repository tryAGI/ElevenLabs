
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A template run and its outputs. Every output exists from the moment the<br/>
    /// run is created and reports its own `status`; the run's `status` rolls them<br/>
    /// up, and the run is finished once it is `completed` or `failed`.<br/>
    /// Example: {"id":"sess_JWr5N6X9ZTqf8jD2LmQb","outputs":{"marketing_title":{"content":"Ride the wave.","id":"Kx2mP7Y4WVrg9kE3NnRc","status":"completed","type":"string"},"product_demo":{"id":"QWr5N6X9ZTqf8jD2La3B","status":"generating","type":"video"},"product_still":{"content_mime_type":"image/png","content_url":"https://storage.googleapis.com/generations/JWr5N6X9ZTqf8jD2LmQb","id":"JWr5N6X9ZTqf8jD2LmQb","status":"completed","type":"image"}},"status":"generating","template_id":"tmpl_abc123","version_id":"ver_01hxyz"}
    /// </summary>
    public sealed partial class TemplateRunResponse
    {
        /// <summary>
        /// The unique identifier of the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The template this run executed, so a webhook consumer running several templates can tell their runs apart without keeping a run-to-template map.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// The template version this run executed. Resolved when the run is created, so a run started with `latest` records the concrete version it ran.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionId { get; set; }

        /// <summary>
        /// The run's status, rolled up from its outputs: `pending` until an output starts, `generating` while any output is unfinished, `completed` once every output has completed, and `failed` once every output has finished and at least one failed. `completed` and `failed` are terminal: the `flows_template_run` webhook fires once the run reaches either.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TemplateRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TemplateRunStatus Status { get; set; }

        /// <summary>
        /// The run's outputs, keyed by output port id. Each is a `TemplateOutput` discriminated on `type`, the `type` of its port's `content_schema`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateOutput> Outputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the run.
        /// </param>
        /// <param name="templateId">
        /// The template this run executed, so a webhook consumer running several templates can tell their runs apart without keeping a run-to-template map.
        /// </param>
        /// <param name="versionId">
        /// The template version this run executed. Resolved when the run is created, so a run started with `latest` records the concrete version it ran.
        /// </param>
        /// <param name="status">
        /// The run's status, rolled up from its outputs: `pending` until an output starts, `generating` while any output is unfinished, `completed` once every output has completed, and `failed` once every output has finished and at least one failed. `completed` and `failed` are terminal: the `flows_template_run` webhook fires once the run reaches either.
        /// </param>
        /// <param name="outputs">
        /// The run's outputs, keyed by output port id. Each is a `TemplateOutput` discriminated on `type`, the `type` of its port's `content_schema`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateRunResponse(
            string id,
            string templateId,
            string versionId,
            global::ElevenLabs.TemplateRunStatus status,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateOutput> outputs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.VersionId = versionId ?? throw new global::System.ArgumentNullException(nameof(versionId));
            this.Status = status;
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunResponse" /> class.
        /// </summary>
        public TemplateRunResponse()
        {
        }

    }
}