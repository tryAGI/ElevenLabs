
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request for a preflight (dry-run) check before running a full template.
    /// </summary>
    public sealed partial class TemplateRunPreflightRequestModel
    {
        /// <summary>
        /// Input values for the run, keyed by input port id. Each value is a Reference{Text,Image,Video,Audio} object re-validated against the input port's modality — see `TemplateRunCreateRequestModel.inputs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        public object? Inputs { get; set; }

        /// <summary>
        /// hCaptcha token for verification. Required only on the anonymous preflight endpoint; ignored when called by an authenticated user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hcaptcha_token")]
        public string? HcaptchaToken { get; set; }

        /// <summary>
        /// Optional content snapshot ``version_id`` to preflight. Same semantics as `TemplateRunCreateRequestModel.version_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_id")]
        public string? VersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunPreflightRequestModel" /> class.
        /// </summary>
        /// <param name="inputs">
        /// Input values for the run, keyed by input port id. Each value is a Reference{Text,Image,Video,Audio} object re-validated against the input port's modality — see `TemplateRunCreateRequestModel.inputs`.
        /// </param>
        /// <param name="hcaptchaToken">
        /// hCaptcha token for verification. Required only on the anonymous preflight endpoint; ignored when called by an authenticated user.
        /// </param>
        /// <param name="versionId">
        /// Optional content snapshot ``version_id`` to preflight. Same semantics as `TemplateRunCreateRequestModel.version_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TemplateRunPreflightRequestModel(
            object? inputs,
            string? hcaptchaToken,
            string? versionId)
        {
            this.Inputs = inputs;
            this.HcaptchaToken = hcaptchaToken;
            this.VersionId = versionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRunPreflightRequestModel" /> class.
        /// </summary>
        public TemplateRunPreflightRequestModel()
        {
        }

    }
}