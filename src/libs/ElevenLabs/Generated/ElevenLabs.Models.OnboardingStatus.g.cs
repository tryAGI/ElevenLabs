
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OnboardingStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasCriteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasAgents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_evaluations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasEvaluations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingStatus" /> class.
        /// </summary>
        /// <param name="hasCriteria"></param>
        /// <param name="hasAgents"></param>
        /// <param name="hasEvaluations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OnboardingStatus(
            bool hasCriteria,
            bool hasAgents,
            bool hasEvaluations)
        {
            this.HasCriteria = hasCriteria;
            this.HasAgents = hasAgents;
            this.HasEvaluations = hasEvaluations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnboardingStatus" /> class.
        /// </summary>
        public OnboardingStatus()
        {
        }
    }
}