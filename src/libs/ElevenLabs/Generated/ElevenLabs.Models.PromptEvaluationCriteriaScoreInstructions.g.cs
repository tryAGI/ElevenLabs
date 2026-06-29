
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Optional free-text instructions describing how to assign values on the numeric scale. Only used when scoring_mode is 'numeric_uniform'.
    /// </summary>
    public sealed partial class PromptEvaluationCriteriaScoreInstructions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}