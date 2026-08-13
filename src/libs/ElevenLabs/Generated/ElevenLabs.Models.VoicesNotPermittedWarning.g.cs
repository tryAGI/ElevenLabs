
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoicesNotPermittedWarning
    {
        /// <summary>
        /// Identifies this warning; branch on it to read the fields below.
        /// </summary>
        /// <default>"voices_not_permitted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "voices_not_permitted";

        /// <summary>
        /// Speakers whose voices were not permitted for cloning. The dub used a replacement voice for each of them; the rest of the speakers are unaffected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SpeakerIds { get; set; }

        /// <summary>
        /// Human-readable description of the warning, for display. The wording may change at any time; branch on `type` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesNotPermittedWarning" /> class.
        /// </summary>
        /// <param name="speakerIds">
        /// Speakers whose voices were not permitted for cloning. The dub used a replacement voice for each of them; the rest of the speakers are unaffected.
        /// </param>
        /// <param name="message">
        /// Human-readable description of the warning, for display. The wording may change at any time; branch on `type` instead.
        /// </param>
        /// <param name="type">
        /// Identifies this warning; branch on it to read the fields below.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoicesNotPermittedWarning(
            global::System.Collections.Generic.IList<string> speakerIds,
            string message,
            string type = "voices_not_permitted")
        {
            this.Type = type;
            this.SpeakerIds = speakerIds ?? throw new global::System.ArgumentNullException(nameof(speakerIds));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoicesNotPermittedWarning" /> class.
        /// </summary>
        public VoicesNotPermittedWarning()
        {
        }

    }
}