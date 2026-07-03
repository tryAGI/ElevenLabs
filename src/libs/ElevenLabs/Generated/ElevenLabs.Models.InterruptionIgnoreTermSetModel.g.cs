
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InterruptionIgnoreTermSetModel
    {
        /// <summary>
        /// Acknowledgements: safe backchannels seeded when interruption ignore terms are turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledgements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Acknowledgements { get; set; }

        /// <summary>
        /// Openers: greetings and presence probes. Opt-in (off by default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Openers { get; set; }

        /// <summary>
        /// Confirmations: affirmation/negation answer words. Opt-in (off by default).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Confirmations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptionIgnoreTermSetModel" /> class.
        /// </summary>
        /// <param name="acknowledgements">
        /// Acknowledgements: safe backchannels seeded when interruption ignore terms are turned on.
        /// </param>
        /// <param name="openers">
        /// Openers: greetings and presence probes. Opt-in (off by default).
        /// </param>
        /// <param name="confirmations">
        /// Confirmations: affirmation/negation answer words. Opt-in (off by default).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InterruptionIgnoreTermSetModel(
            global::System.Collections.Generic.IList<string> acknowledgements,
            global::System.Collections.Generic.IList<string> openers,
            global::System.Collections.Generic.IList<string> confirmations)
        {
            this.Acknowledgements = acknowledgements ?? throw new global::System.ArgumentNullException(nameof(acknowledgements));
            this.Openers = openers ?? throw new global::System.ArgumentNullException(nameof(openers));
            this.Confirmations = confirmations ?? throw new global::System.ArgumentNullException(nameof(confirmations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InterruptionIgnoreTermSetModel" /> class.
        /// </summary>
        public InterruptionIgnoreTermSetModel()
        {
        }

    }
}