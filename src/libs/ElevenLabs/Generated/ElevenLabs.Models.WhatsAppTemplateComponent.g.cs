
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WhatsAppTemplateComponent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public string? Format { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buttons")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateComponentButton>? Buttons { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateComponent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="format"></param>
        /// <param name="text"></param>
        /// <param name="buttons"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhatsAppTemplateComponent(
            string type,
            string? format,
            string? text,
            global::System.Collections.Generic.IList<global::ElevenLabs.WhatsAppTemplateComponentButton>? buttons)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Format = format;
            this.Text = text;
            this.Buttons = buttons;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhatsAppTemplateComponent" /> class.
        /// </summary>
        public WhatsAppTemplateComponent()
        {
        }

    }
}