
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The workspace's pronunciation rules, shared by every receptionist and the assistant.
    /// </summary>
    public sealed partial class ReceptionPronunciationRulesResponse
    {
        /// <summary>
        /// The full list of pronunciation rules; sending it replaces the stored list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionPronunciationRule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionPronunciationRulesResponse" /> class.
        /// </summary>
        /// <param name="rules">
        /// The full list of pronunciation rules; sending it replaces the stored list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionPronunciationRulesResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionPronunciationRule>? rules)
        {
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionPronunciationRulesResponse" /> class.
        /// </summary>
        public ReceptionPronunciationRulesResponse()
        {
        }

    }
}