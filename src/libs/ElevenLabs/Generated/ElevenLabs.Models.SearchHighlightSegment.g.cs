
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchHighlightSegment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_hit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsHit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchHighlightSegment" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="isHit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchHighlightSegment(
            string value,
            bool isHit)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.IsHit = isHit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchHighlightSegment" /> class.
        /// </summary>
        public SearchHighlightSegment()
        {
        }
    }
}