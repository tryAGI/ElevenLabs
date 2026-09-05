
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An optionally-sized icon for display in a user interface (2025-11-25+).
    /// </summary>
    public sealed partial class Icon
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("src")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Src { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public string? MimeType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sizes")]
        public global::System.Collections.Generic.IList<string>? Sizes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        public global::ElevenLabs.IconTheme2? Theme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Icon" /> class.
        /// </summary>
        /// <param name="src"></param>
        /// <param name="mimeType"></param>
        /// <param name="sizes"></param>
        /// <param name="theme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Icon(
            string src,
            string? mimeType,
            global::System.Collections.Generic.IList<string>? sizes,
            global::ElevenLabs.IconTheme2? theme)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.MimeType = mimeType;
            this.Sizes = sizes;
            this.Theme = theme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Icon" /> class.
        /// </summary>
        public Icon()
        {
        }

    }
}