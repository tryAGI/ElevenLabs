
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The accepted re-dub: what it covers and what it cost.
    /// </summary>
    public sealed partial class DubbingRegenerateResponse
    {
        /// <summary>
        /// The segments this re-dub re-synthesizes: those with edits to apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regenerated_segment_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RegeneratedSegmentIds { get; set; }

        /// <summary>
        /// Seconds of audio this re-dub covers -- the edited regions only, never the whole target. `charged_seconds` is the part of it that was billed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regenerated_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RegeneratedSeconds { get; set; }

        /// <summary>
        /// Seconds actually billed, after the free-regeneration allowance. Zero when the re-dub cost nothing -- the allowance covered all of it, or the project's included generation did.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charged_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ChargedSeconds { get; set; }

        /// <summary>
        /// Free-regeneration seconds left for this language target after this re-dub. The allowance is the source's own duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("free_regeneration_seconds_remaining")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FreeRegenerationSecondsRemaining { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingRegenerateResponse" /> class.
        /// </summary>
        /// <param name="regeneratedSegmentIds">
        /// The segments this re-dub re-synthesizes: those with edits to apply.
        /// </param>
        /// <param name="regeneratedSeconds">
        /// Seconds of audio this re-dub covers -- the edited regions only, never the whole target. `charged_seconds` is the part of it that was billed.
        /// </param>
        /// <param name="chargedSeconds">
        /// Seconds actually billed, after the free-regeneration allowance. Zero when the re-dub cost nothing -- the allowance covered all of it, or the project's included generation did.
        /// </param>
        /// <param name="freeRegenerationSecondsRemaining">
        /// Free-regeneration seconds left for this language target after this re-dub. The allowance is the source's own duration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingRegenerateResponse(
            global::System.Collections.Generic.IList<string> regeneratedSegmentIds,
            double regeneratedSeconds,
            double chargedSeconds,
            double freeRegenerationSecondsRemaining)
        {
            this.RegeneratedSegmentIds = regeneratedSegmentIds ?? throw new global::System.ArgumentNullException(nameof(regeneratedSegmentIds));
            this.RegeneratedSeconds = regeneratedSeconds;
            this.ChargedSeconds = chargedSeconds;
            this.FreeRegenerationSecondsRemaining = freeRegenerationSecondsRemaining;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingRegenerateResponse" /> class.
        /// </summary>
        public DubbingRegenerateResponse()
        {
        }

    }
}