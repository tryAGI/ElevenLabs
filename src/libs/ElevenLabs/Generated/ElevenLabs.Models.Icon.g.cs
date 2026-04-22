
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An icon for display in user interfaces.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Icon(
            string src,
            string? mimeType,
            global::System.Collections.Generic.IList<string>? sizes)
        {
            this.Src = src ?? throw new global::System.ArgumentNullException(nameof(src));
            this.MimeType = mimeType;
            this.Sizes = sizes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Icon" /> class.
        /// </summary>
        public Icon()
        {
        }
    }
}