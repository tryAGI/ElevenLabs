
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubmitWhatsAppMessageConfig
    {
        /// <summary>
        /// Default Value: message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// Names the approved Meta template to send. The server loads the template<br/>
        /// itself, so the client never supplies its components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SubmitWhatsAppTemplateRef Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitWhatsAppMessageConfig" /> class.
        /// </summary>
        /// <param name="template">
        /// Names the approved Meta template to send. The server loads the template<br/>
        /// itself, so the client never supplies its components.
        /// </param>
        /// <param name="mode">
        /// Default Value: message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitWhatsAppMessageConfig(
            global::ElevenLabs.SubmitWhatsAppTemplateRef template,
            string? mode)
        {
            this.Mode = mode;
            this.Template = template ?? throw new global::System.ArgumentNullException(nameof(template));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitWhatsAppMessageConfig" /> class.
        /// </summary>
        public SubmitWhatsAppMessageConfig()
        {
        }

    }
}