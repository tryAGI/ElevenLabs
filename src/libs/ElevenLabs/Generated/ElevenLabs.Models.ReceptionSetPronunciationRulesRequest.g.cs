
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request model for replacing the workspace's pronunciation rules.
    /// </summary>
    public sealed partial class ReceptionSetPronunciationRulesRequest
    {
        /// <summary>
        /// The full list of pronunciation rules; sending it replaces the stored list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionPronunciationRule> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionSetPronunciationRulesRequest" /> class.
        /// </summary>
        /// <param name="rules">
        /// The full list of pronunciation rules; sending it replaces the stored list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionSetPronunciationRulesRequest(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionPronunciationRule> rules)
        {
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionSetPronunciationRulesRequest" /> class.
        /// </summary>
        public ReceptionSetPronunciationRulesRequest()
        {
        }

    }
}