
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponseNormalizedAlignment
    {
        /// <summary>
        /// Array of normalized characters including spaces
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        public global::System.Collections.Generic.IList<string>? Characters { get; set; }

        /// <summary>
        /// Array of start times in seconds for normalized characters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_start_times_seconds")]
        public global::System.Collections.Generic.IList<double>? CharacterStartTimesSeconds { get; set; }

        /// <summary>
        /// Array of end times in seconds for normalized characters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_end_times_seconds")]
        public global::System.Collections.Generic.IList<double>? CharacterEndTimesSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponseNormalizedAlignment" /> class.
        /// </summary>
        /// <param name="characters">
        /// Array of normalized characters including spaces
        /// </param>
        /// <param name="characterStartTimesSeconds">
        /// Array of start times in seconds for normalized characters
        /// </param>
        /// <param name="characterEndTimesSeconds">
        /// Array of end times in seconds for normalized characters
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponseNormalizedAlignment(
            global::System.Collections.Generic.IList<string>? characters,
            global::System.Collections.Generic.IList<double>? characterStartTimesSeconds,
            global::System.Collections.Generic.IList<double>? characterEndTimesSeconds)
        {
            this.Characters = characters;
            this.CharacterStartTimesSeconds = characterStartTimesSeconds;
            this.CharacterEndTimesSeconds = characterEndTimesSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponseNormalizedAlignment" /> class.
        /// </summary>
        public TextToSpeechWithTimestampsV1TextToSpeechVoiceIdWithTimestampsPostResponseNormalizedAlignment()
        {
        }
    }
}