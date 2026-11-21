
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WhatsAppVoiceConfig
    {
        /// <summary>
        /// Default Value: voice
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// The approved template that asks the contact for permission to call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_call_permission_request_template_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WhatsappCallPermissionRequestTemplateName { get; set; }

        /// <summary>
        /// The language code of that template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whatsapp_call_permission_request_template_language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WhatsappCallPermissionRequestTemplateLanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppVoiceConfig" /> class.
        /// </summary>
        /// <param name="whatsappCallPermissionRequestTemplateName">
        /// The approved template that asks the contact for permission to call.
        /// </param>
        /// <param name="whatsappCallPermissionRequestTemplateLanguageCode">
        /// The language code of that template.
        /// </param>
        /// <param name="mode">
        /// Default Value: voice
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppVoiceConfig(
            string whatsappCallPermissionRequestTemplateName,
            string whatsappCallPermissionRequestTemplateLanguageCode,
            string? mode)
        {
            this.Mode = mode;
            this.WhatsappCallPermissionRequestTemplateName = whatsappCallPermissionRequestTemplateName ?? throw new global::System.ArgumentNullException(nameof(whatsappCallPermissionRequestTemplateName));
            this.WhatsappCallPermissionRequestTemplateLanguageCode = whatsappCallPermissionRequestTemplateLanguageCode ?? throw new global::System.ArgumentNullException(nameof(whatsappCallPermissionRequestTemplateLanguageCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppVoiceConfig" /> class.
        /// </summary>
        public WhatsAppVoiceConfig()
        {
        }

    }
}