
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SongSection
    {
        /// <summary>
        /// The name of the section. Must be between 1 and 100 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SectionName { get; set; }

        /// <summary>
        /// The styles that should be present in this section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_local_styles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PositiveLocalStyles { get; set; }

        /// <summary>
        /// The styles that should not be present in this section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_local_styles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NegativeLocalStyles { get; set; }

        /// <summary>
        /// The duration of the section in milliseconds. Must be between 3000ms and 120000ms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// The lyrics of the section.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Lines { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SongSection" /> class.
        /// </summary>
        /// <param name="sectionName">
        /// The name of the section. Must be between 1 and 100 characters.
        /// </param>
        /// <param name="positiveLocalStyles">
        /// The styles that should be present in this section.
        /// </param>
        /// <param name="negativeLocalStyles">
        /// The styles that should not be present in this section.
        /// </param>
        /// <param name="durationMs">
        /// The duration of the section in milliseconds. Must be between 3000ms and 120000ms.
        /// </param>
        /// <param name="lines">
        /// The lyrics of the section.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SongSection(
            string sectionName,
            global::System.Collections.Generic.IList<string> positiveLocalStyles,
            global::System.Collections.Generic.IList<string> negativeLocalStyles,
            int durationMs,
            global::System.Collections.Generic.IList<string> lines)
        {
            this.SectionName = sectionName ?? throw new global::System.ArgumentNullException(nameof(sectionName));
            this.PositiveLocalStyles = positiveLocalStyles ?? throw new global::System.ArgumentNullException(nameof(positiveLocalStyles));
            this.NegativeLocalStyles = negativeLocalStyles ?? throw new global::System.ArgumentNullException(nameof(negativeLocalStyles));
            this.DurationMs = durationMs;
            this.Lines = lines ?? throw new global::System.ArgumentNullException(nameof(lines));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SongSection" /> class.
        /// </summary>
        public SongSection()
        {
        }
    }
}