
#nullable enable

namespace ElevenLabs.TextToDialogueRealtime
{
    /// <summary>
    /// Character-level alignment data (field names use snake_case in JSON).
    /// </summary>
    public sealed partial class DialogueTextAlignment
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chars")]
        public global::System.Collections.Generic.IList<string>? Chars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("char_start_times_ms")]
        public global::System.Collections.Generic.IList<int>? CharStartTimesMs { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("char_durations_ms")]
        public global::System.Collections.Generic.IList<int>? CharDurationsMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogueTextAlignment" /> class.
        /// </summary>
        /// <param name="chars"></param>
        /// <param name="charStartTimesMs"></param>
        /// <param name="charDurationsMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DialogueTextAlignment(
            global::System.Collections.Generic.IList<string>? chars,
            global::System.Collections.Generic.IList<int>? charStartTimesMs,
            global::System.Collections.Generic.IList<int>? charDurationsMs)
        {
            this.Chars = chars;
            this.CharStartTimesMs = charStartTimesMs;
            this.CharDurationsMs = charDurationsMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogueTextAlignment" /> class.
        /// </summary>
        public DialogueTextAlignment()
        {
        }

    }
}