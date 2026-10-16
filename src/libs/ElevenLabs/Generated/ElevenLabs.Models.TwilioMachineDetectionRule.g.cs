
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Action to take on a live call for the given AMD verdicts.
    /// </summary>
    public sealed partial class TwilioMachineDetectionRule
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TwilioMachineDetectionActionJsonConverter))]
        public global::ElevenLabs.TwilioMachineDetectionAction Action { get; set; }

        /// <summary>
        /// Verdicts that trigger the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answered_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.TwilioAnsweredBy> AnsweredBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioMachineDetectionRule" /> class.
        /// </summary>
        /// <param name="answeredBy">
        /// Verdicts that trigger the action.
        /// </param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TwilioMachineDetectionRule(
            global::System.Collections.Generic.IList<global::ElevenLabs.TwilioAnsweredBy> answeredBy,
            global::ElevenLabs.TwilioMachineDetectionAction action)
        {
            this.Action = action;
            this.AnsweredBy = answeredBy ?? throw new global::System.ArgumentNullException(nameof(answeredBy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TwilioMachineDetectionRule" /> class.
        /// </summary>
        public TwilioMachineDetectionRule()
        {
        }

    }
}