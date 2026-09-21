
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request body of ``POST /v1/flows/templates/{template_id}/runs``.<br/>
    /// Example: {"inputs":{"prompt":"a corgi on a surfboard","reference":{"asset_id":"5xM2KqOnZyce22SPZ9d4","type":"asset"}},"version_id":"latest","webhook":{"type":"all"}}
    /// </summary>
    public sealed partial class TemplateRunCreateRequest
    {
        /// <summary>
        /// Input values keyed by input port id. Every input port of the version being run must be given; a missing or unknown id is rejected. Pass `{}` for a template with no inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateRunInput> Inputs { get; set; }

        /// <summary>
        /// The template snapshot to run. Pass a specific version id to pin that snapshot, or `latest` (the default when omitted) to run the template's most recently published version. Only published versions can be pinned, except by the template's owner, who may also pin an unpublished saved snapshot to try it out before publishing. The live draft is never run through this API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Include to send the run's result to the workspace's configured flows webhooks once the run's `status` reaches `completed` or `failed`. One event for the whole run: the `flows_template_run` event's `data` matches the terminal response of `GET /v1/flows/templates/{template_id}/runs/{run_id}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::ElevenLabs.WebhookTarget? Webhook { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunCreateRequest" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Input values keyed by input port id. Every input port of the version being run must be given; a missing or unknown id is rejected. Pass `{}` for a template with no inputs.
        /// </param>
        /// <param name="versionId">
        /// The template snapshot to run. Pass a specific version id to pin that snapshot, or `latest` (the default when omitted) to run the template's most recently published version. Only published versions can be pinned, except by the template's owner, who may also pin an unpublished saved snapshot to try it out before publishing. The live draft is never run through this API.
        /// </param>
        /// <param name="webhook">
        /// Include to send the run's result to the workspace's configured flows webhooks once the run's `status` reaches `completed` or `failed`. One event for the whole run: the `flows_template_run` event's `data` matches the terminal response of `GET /v1/flows/templates/{template_id}/runs/{run_id}`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateRunCreateRequest(
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.TemplateRunInput> inputs,
            string? versionId,
            global::ElevenLabs.WebhookTarget? webhook)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
            this.VersionId = versionId;
            this.Webhook = webhook;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunCreateRequest" /> class.
        /// </summary>
        public TemplateRunCreateRequest()
        {
        }

    }
}