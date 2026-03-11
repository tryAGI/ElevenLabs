
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSegment
    {
        /// <summary>
        /// The voice ID used for this segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// Start time of this voice segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double StartTimeSeconds { get; set; } = default!;

        /// <summary>
        /// End time of this voice segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double EndTimeSeconds { get; set; } = default!;

        /// <summary>
        /// Start index in the characters array
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CharacterStartIndex { get; set; } = default!;

        /// <summary>
        /// End index in the characters array (exclusive)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int CharacterEndIndex { get; set; } = default!;

        /// <summary>
        /// Line of the dialogue (script) that this segment is a part of.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dialogue_input_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int DialogueInputIndex { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSegment" /> class.
        /// </summary>
        /// <param name="voiceId">
        /// The voice ID used for this segment
        /// </param>
        /// <param name="startTimeSeconds">
        /// Start time of this voice segment
        /// </param>
        /// <param name="endTimeSeconds">
        /// End time of this voice segment
        /// </param>
        /// <param name="characterStartIndex">
        /// Start index in the characters array
        /// </param>
        /// <param name="characterEndIndex">
        /// End index in the characters array (exclusive)
        /// </param>
        /// <param name="dialogueInputIndex">
        /// Line of the dialogue (script) that this segment is a part of.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSegment(
            string voiceId,
            double startTimeSeconds,
            double endTimeSeconds,
            int characterStartIndex,
            int characterEndIndex,
            int dialogueInputIndex)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.StartTimeSeconds = startTimeSeconds;
            this.EndTimeSeconds = endTimeSeconds;
            this.CharacterStartIndex = characterStartIndex;
            this.CharacterEndIndex = characterEndIndex;
            this.DialogueInputIndex = dialogueInputIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSegment" /> class.
        /// </summary>
        public VoiceSegment()
        {
        }
    }
}