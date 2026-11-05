
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoRebaseAttempt
    {
        /// <summary>
        /// Result of the attempt. succeeded: the branch has the followed branch's changes. conflict: both branches changed the same settings. no_common_ancestor: the two branches share no version. rejected: the rebased configuration failed validation. error: the attempt failed unexpectedly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AutoRebaseOutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AutoRebaseOutcome Outcome { get; set; }

        /// <summary>
        /// Unix seconds when the attempt ran
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attempted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AttemptedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRebaseAttempt" /> class.
        /// </summary>
        /// <param name="outcome">
        /// Result of the attempt. succeeded: the branch has the followed branch's changes. conflict: both branches changed the same settings. no_common_ancestor: the two branches share no version. rejected: the rebased configuration failed validation. error: the attempt failed unexpectedly.
        /// </param>
        /// <param name="attemptedAt">
        /// Unix seconds when the attempt ran
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoRebaseAttempt(
            global::ElevenLabs.AutoRebaseOutcome outcome,
            int attemptedAt)
        {
            this.Outcome = outcome;
            this.AttemptedAt = attemptedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoRebaseAttempt" /> class.
        /// </summary>
        public AutoRebaseAttempt()
        {
        }

    }
}