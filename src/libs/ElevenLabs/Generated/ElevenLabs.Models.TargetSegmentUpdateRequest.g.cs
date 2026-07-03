
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// An edit to a target segment's translation.
    /// </summary>
    public sealed partial class TargetSegmentUpdateRequest
    {
        /// <summary>
        /// New translated text, or null to mark the segment for re-translation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translation")]
        public string? Translation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetSegmentUpdateRequest" /> class.
        /// </summary>
        /// <param name="translation">
        /// New translated text, or null to mark the segment for re-translation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TargetSegmentUpdateRequest(
            string? translation)
        {
            this.Translation = translation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetSegmentUpdateRequest" /> class.
        /// </summary>
        public TargetSegmentUpdateRequest()
        {
        }

    }
}