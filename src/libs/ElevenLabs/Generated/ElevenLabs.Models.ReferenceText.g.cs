
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Reference to text output from another node or generation, or inline text.
    /// </summary>
    public sealed partial class ReferenceText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_node_id")]
        public string? TemplateNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_text")]
        public string? InlineText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceText" /> class.
        /// </summary>
        /// <param name="generationId"></param>
        /// <param name="templateNodeId"></param>
        /// <param name="inlineText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReferenceText(
            string? generationId,
            string? templateNodeId,
            string? inlineText)
        {
            this.GenerationId = generationId;
            this.TemplateNodeId = templateNodeId;
            this.InlineText = inlineText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceText" /> class.
        /// </summary>
        public ReferenceText()
        {
        }
    }
}