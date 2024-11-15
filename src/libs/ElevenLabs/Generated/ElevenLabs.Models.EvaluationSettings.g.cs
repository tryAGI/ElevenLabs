
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Settings to evaluate an agent's performance.<br/>
    /// Agents are evaluated against a set of criteria, with success being defined as meeting some combination of those criteria.
    /// </summary>
    public sealed partial class EvaluationSettings
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.PromptEvaluationCriteria>? Criteria { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSettings" /> class.
        /// </summary>
        /// <param name="criteria"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public EvaluationSettings(
            global::System.Collections.Generic.IList<global::ElevenLabs.PromptEvaluationCriteria>? criteria)
        {
            this.Criteria = criteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationSettings" /> class.
        /// </summary>
        public EvaluationSettings()
        {
        }
    }
}