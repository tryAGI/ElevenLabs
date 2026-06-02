
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"character_end_times_ms":[100,200,300,400,500],"character_start_times_ms":[0,100,200,300,400],"characters":["H","e","l","l","o"]}
    /// </summary>
    public sealed partial class TextAlignmentResponseModel
    {
        /// <summary>
        /// Array of characters in the text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Characters { get; set; }

        /// <summary>
        /// Start times for each character in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_start_times_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> CharacterStartTimesMs { get; set; }

        /// <summary>
        /// End times for each character in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_end_times_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> CharacterEndTimesMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAlignmentResponseModel" /> class.
        /// </summary>
        /// <param name="characters">
        /// Array of characters in the text
        /// </param>
        /// <param name="characterStartTimesMs">
        /// Start times for each character in milliseconds
        /// </param>
        /// <param name="characterEndTimesMs">
        /// End times for each character in milliseconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextAlignmentResponseModel(
            global::System.Collections.Generic.IList<string> characters,
            global::System.Collections.Generic.IList<int> characterStartTimesMs,
            global::System.Collections.Generic.IList<int> characterEndTimesMs)
        {
            this.Characters = characters ?? throw new global::System.ArgumentNullException(nameof(characters));
            this.CharacterStartTimesMs = characterStartTimesMs ?? throw new global::System.ArgumentNullException(nameof(characterStartTimesMs));
            this.CharacterEndTimesMs = characterEndTimesMs ?? throw new global::System.ArgumentNullException(nameof(characterEndTimesMs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAlignmentResponseModel" /> class.
        /// </summary>
        public TextAlignmentResponseModel()
        {
        }

    }
}