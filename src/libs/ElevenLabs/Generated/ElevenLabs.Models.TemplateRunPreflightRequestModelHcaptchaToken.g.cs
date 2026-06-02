
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// hCaptcha token for verification. Required only on the anonymous preflight endpoint; ignored when called by an authenticated user.
    /// </summary>
    public sealed partial class TemplateRunPreflightRequestModelHcaptchaToken
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}