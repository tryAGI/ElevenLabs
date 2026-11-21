
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Names the approved Meta template to send. The server loads the template<br/>
    /// itself, so the client never supplies its components.
    /// </summary>
    public sealed partial class SubmitWhatsAppTemplateRef
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The template's language code, such as `en_US`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitWhatsAppTemplateRef" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="language">
        /// The template's language code, such as `en_US`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitWhatsAppTemplateRef(
            string name,
            string language)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitWhatsAppTemplateRef" /> class.
        /// </summary>
        public SubmitWhatsAppTemplateRef()
        {
        }

    }
}