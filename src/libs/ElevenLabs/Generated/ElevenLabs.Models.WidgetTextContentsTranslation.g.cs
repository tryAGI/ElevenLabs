
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetTextContentsTranslation
    {
        /// <summary>
        /// The source text each translated field was derived from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::System.Collections.Generic.Dictionary<string, string>? Source { get; set; }

        /// <summary>
        /// The last auto-translated output for each translated field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::System.Collections.Generic.Dictionary<string, string>? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetTextContentsTranslation" /> class.
        /// </summary>
        /// <param name="source">
        /// The source text each translated field was derived from
        /// </param>
        /// <param name="text">
        /// The last auto-translated output for each translated field
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WidgetTextContentsTranslation(
            global::System.Collections.Generic.Dictionary<string, string>? source,
            global::System.Collections.Generic.Dictionary<string, string>? text)
        {
            this.Source = source;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetTextContentsTranslation" /> class.
        /// </summary>
        public WidgetTextContentsTranslation()
        {
        }

    }
}