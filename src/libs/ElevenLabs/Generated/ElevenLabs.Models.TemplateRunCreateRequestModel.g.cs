
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request to create/start a template run.<br/>
    /// Example: {"inputs":{"target_language":{"inline_text":"Spanish"},"video":{"content_asset_id":"asset_video_001"}}}
    /// </summary>
    public sealed partial class TemplateRunCreateRequestModel
    {
        /// <summary>
        /// Input values for the run, keyed by input port id. Each value is a Reference{Text,Image,Video,Audio} object; the server re-validates the binding against the input port's modality at run time, so populate the fields that match the value you have (`content_asset_id`, `generation_id`, `template_node_id`, `studio_clip`, or `inline_text` for text).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// hCaptcha token for verification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hcaptcha_token")]
        public string? HcaptchaToken { get; set; }

        /// <summary>
        /// Optional content snapshot ``version_id`` to execute. Omit to use the live template in the owning workspace, or the latest approved snapshot for anonymous / cross-workspace access.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunCreateRequestModel" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Input values for the run, keyed by input port id. Each value is a Reference{Text,Image,Video,Audio} object; the server re-validates the binding against the input port's modality at run time, so populate the fields that match the value you have (`content_asset_id`, `generation_id`, `template_node_id`, `studio_clip`, or `inline_text` for text).
        /// </param>
        /// <param name="hcaptchaToken">
        /// hCaptcha token for verification.
        /// </param>
        /// <param name="versionId">
        /// Optional content snapshot ``version_id`` to execute. Omit to use the live template in the owning workspace, or the latest approved snapshot for anonymous / cross-workspace access.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateRunCreateRequestModel(
            object? inputs,
            string? hcaptchaToken,
            string? versionId)
        {
            this.Inputs = inputs;
            this.HcaptchaToken = hcaptchaToken;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunCreateRequestModel" /> class.
        /// </summary>
        public TemplateRunCreateRequestModel()
        {
        }

    }
}