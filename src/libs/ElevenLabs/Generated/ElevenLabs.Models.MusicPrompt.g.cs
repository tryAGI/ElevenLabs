
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MusicPrompt
    {
        /// <summary>
        /// The styles that should be present in the entire song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_global_styles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PositiveGlobalStyles { get; set; }

        /// <summary>
        /// The styles that should not be present in the entire song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_global_styles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NegativeGlobalStyles { get; set; }

        /// <summary>
        /// The sections of the song.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.SongSection> Sections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicPrompt" /> class.
        /// </summary>
        /// <param name="positiveGlobalStyles">
        /// The styles that should be present in the entire song.
        /// </param>
        /// <param name="negativeGlobalStyles">
        /// The styles that should not be present in the entire song.
        /// </param>
        /// <param name="sections">
        /// The sections of the song.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicPrompt(
            global::System.Collections.Generic.IList<string> positiveGlobalStyles,
            global::System.Collections.Generic.IList<string> negativeGlobalStyles,
            global::System.Collections.Generic.IList<global::ElevenLabs.SongSection> sections)
        {
            this.PositiveGlobalStyles = positiveGlobalStyles ?? throw new global::System.ArgumentNullException(nameof(positiveGlobalStyles));
            this.NegativeGlobalStyles = negativeGlobalStyles ?? throw new global::System.ArgumentNullException(nameof(negativeGlobalStyles));
            this.Sections = sections ?? throw new global::System.ArgumentNullException(nameof(sections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicPrompt" /> class.
        /// </summary>
        public MusicPrompt()
        {
        }
    }
}