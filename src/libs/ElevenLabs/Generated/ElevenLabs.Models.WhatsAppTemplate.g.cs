
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WhatsAppTemplate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// https://developers.facebook.com/documentation/business-messaging/whatsapp/templates/supported-languages
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Default Value: POSITIONAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WhatsAppTemplateParameterFormatJsonConverter))]
        public global::ElevenLabs.WhatsAppTemplateParameterFormat? ParameterFormat { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("components")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateComponent> Components { get; set; }

        /// <summary>
        /// https://developers.facebook.com/docs/graph-api/reference/whats-app-business-account/message_templates/
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="language">
        /// https://developers.facebook.com/documentation/business-messaging/whatsapp/templates/supported-languages
        /// </param>
        /// <param name="components"></param>
        /// <param name="parameterFormat">
        /// Default Value: POSITIONAL
        /// </param>
        /// <param name="category">
        /// https://developers.facebook.com/docs/graph-api/reference/whats-app-business-account/message_templates/
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppTemplate(
            string name,
            string language,
            global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateComponent> components,
            global::ElevenLabs.WhatsAppTemplateParameterFormat? parameterFormat,
            string? category)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.ParameterFormat = parameterFormat;
            this.Components = components ?? throw new global::System.ArgumentNullException(nameof(components));
            this.Category = category;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplate" /> class.
        /// </summary>
        public WhatsAppTemplate()
        {
        }

    }
}