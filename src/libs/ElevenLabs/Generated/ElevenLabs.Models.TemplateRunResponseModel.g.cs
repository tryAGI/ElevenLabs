
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A single execution of a template.<br/>
    /// Example: {"actual_cost_cents":145.0,"content_generation_session":{"id":"sess_1","iterations":[],"user_id":"user_456","workspace_id":"ws_123"},"created_at_unix":1704067200,"estimated_cost_cents":150.0,"finished_at_unix":1704067320,"id":"run_xyz789","input_ports":[{"id":"video","modality":"video","name":"Input Video","value":{"content_asset_id":"asset_video_001"}},{"id":"target_language","modality":"text","name":"Target Language","value":{"inline_text":"Spanish"}}],"inputs":{"target_language":{"inline_text":"Spanish"},"video":{"content_asset_id":"asset_video_001"}},"output_ports":[{"id":"result","modality":"image","name":"Final Image"}],"started_at_unix":1704067210,"status":"completed","template_id":"tmpl_abc123","user_id":"user_456","workspace_id":"ws_123"}
    /// </summary>
    public sealed partial class TemplateRunResponseModel
    {
        /// <summary>
        /// Unique identifier for this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the template being executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// ID of the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// ID of the user who started the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Overall status of the run.<br/>
        /// Default Value: pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ContentGenerationStatusJsonConverter))]
        public global::ElevenLabs.ContentGenerationStatus? Status { get; set; }

        /// <summary>
        /// Input values provided for this run, keyed by input port id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// Input ports with per-port run values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_ports")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInputPortResponseModel>? InputPorts { get; set; }

        /// <summary>
        /// Details of the content generation session associated with this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_generation_session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ContentGenerationSessionResponseModel ContentGenerationSession { get; set; }

        /// <summary>
        /// Content generation outputs for this run, keyed by output port id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ContentGenerationResponseModel>? Outputs { get; set; }

        /// <summary>
        /// Output ports with per-port run values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_ports")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunOutputPortResponseModel>? OutputPorts { get; set; }

        /// <summary>
        /// Estimated cost in cents before execution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_cost_cents")]
        public double? EstimatedCostCents { get; set; }

        /// <summary>
        /// Actual cost in cents after execution completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actual_cost_cents")]
        public double? ActualCostCents { get; set; }

        /// <summary>
        /// Unix timestamp when the run was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAtUnix { get; set; }

        /// <summary>
        /// Unix timestamp when execution started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at_unix")]
        public int? StartedAtUnix { get; set; }

        /// <summary>
        /// Unix timestamp when execution finished.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at_unix")]
        public int? FinishedAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this run.
        /// </param>
        /// <param name="templateId">
        /// ID of the template being executed.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace.
        /// </param>
        /// <param name="userId">
        /// ID of the user who started the run.
        /// </param>
        /// <param name="contentGenerationSession">
        /// Details of the content generation session associated with this run.
        /// </param>
        /// <param name="createdAtUnix">
        /// Unix timestamp when the run was created.
        /// </param>
        /// <param name="status">
        /// Overall status of the run.<br/>
        /// Default Value: pending
        /// </param>
        /// <param name="inputs">
        /// Input values provided for this run, keyed by input port id.
        /// </param>
        /// <param name="inputPorts">
        /// Input ports with per-port run values.
        /// </param>
        /// <param name="outputs">
        /// Content generation outputs for this run, keyed by output port id.
        /// </param>
        /// <param name="outputPorts">
        /// Output ports with per-port run values.
        /// </param>
        /// <param name="estimatedCostCents">
        /// Estimated cost in cents before execution.
        /// </param>
        /// <param name="actualCostCents">
        /// Actual cost in cents after execution completes.
        /// </param>
        /// <param name="startedAtUnix">
        /// Unix timestamp when execution started.
        /// </param>
        /// <param name="finishedAtUnix">
        /// Unix timestamp when execution finished.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateRunResponseModel(
            string id,
            string templateId,
            string workspaceId,
            string userId,
            global::ElevenLabs.ContentGenerationSessionResponseModel contentGenerationSession,
            global::System.DateTimeOffset createdAtUnix,
            global::ElevenLabs.ContentGenerationStatus? status,
            object? inputs,
            global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInputPortResponseModel>? inputPorts,
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ContentGenerationResponseModel>? outputs,
            global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunOutputPortResponseModel>? outputPorts,
            double? estimatedCostCents,
            double? actualCostCents,
            int? startedAtUnix,
            int? finishedAtUnix)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Status = status;
            this.Inputs = inputs;
            this.InputPorts = inputPorts;
            this.ContentGenerationSession = contentGenerationSession ?? throw new global::System.ArgumentNullException(nameof(contentGenerationSession));
            this.Outputs = outputs;
            this.OutputPorts = outputPorts;
            this.EstimatedCostCents = estimatedCostCents;
            this.ActualCostCents = actualCostCents;
            this.CreatedAtUnix = createdAtUnix;
            this.StartedAtUnix = startedAtUnix;
            this.FinishedAtUnix = finishedAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunResponseModel" /> class.
        /// </summary>
        public TemplateRunResponseModel()
        {
        }

    }
}