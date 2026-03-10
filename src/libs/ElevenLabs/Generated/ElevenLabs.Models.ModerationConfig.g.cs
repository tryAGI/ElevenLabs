
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModerationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual")]
        public global::ElevenLabs.ThresholdGuardrail? Sexual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        public global::ElevenLabs.ThresholdGuardrail? Violence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence_graphic")]
        public global::ElevenLabs.ThresholdGuardrail? ViolenceGraphic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment")]
        public global::ElevenLabs.ThresholdGuardrail? Harassment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment_threatening")]
        public global::ElevenLabs.ThresholdGuardrail? HarassmentThreatening { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate")]
        public global::ElevenLabs.ThresholdGuardrail? Hate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hate_threatening")]
        public global::ElevenLabs.ThresholdGuardrail? HateThreatening { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_harm_instructions")]
        public global::ElevenLabs.ThresholdGuardrail? SelfHarmInstructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_harm")]
        public global::ElevenLabs.ThresholdGuardrail? SelfHarm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_harm_intent")]
        public global::ElevenLabs.ThresholdGuardrail? SelfHarmIntent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexual_minors")]
        public global::ElevenLabs.ThresholdGuardrail? SexualMinors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationConfig" /> class.
        /// </summary>
        /// <param name="sexual"></param>
        /// <param name="violence"></param>
        /// <param name="violenceGraphic"></param>
        /// <param name="harassment"></param>
        /// <param name="harassmentThreatening"></param>
        /// <param name="hate"></param>
        /// <param name="hateThreatening"></param>
        /// <param name="selfHarmInstructions"></param>
        /// <param name="selfHarm"></param>
        /// <param name="selfHarmIntent"></param>
        /// <param name="sexualMinors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModerationConfig(
            global::ElevenLabs.ThresholdGuardrail? sexual,
            global::ElevenLabs.ThresholdGuardrail? violence,
            global::ElevenLabs.ThresholdGuardrail? violenceGraphic,
            global::ElevenLabs.ThresholdGuardrail? harassment,
            global::ElevenLabs.ThresholdGuardrail? harassmentThreatening,
            global::ElevenLabs.ThresholdGuardrail? hate,
            global::ElevenLabs.ThresholdGuardrail? hateThreatening,
            global::ElevenLabs.ThresholdGuardrail? selfHarmInstructions,
            global::ElevenLabs.ThresholdGuardrail? selfHarm,
            global::ElevenLabs.ThresholdGuardrail? selfHarmIntent,
            global::ElevenLabs.ThresholdGuardrail? sexualMinors)
        {
            this.Sexual = sexual;
            this.Violence = violence;
            this.ViolenceGraphic = violenceGraphic;
            this.Harassment = harassment;
            this.HarassmentThreatening = harassmentThreatening;
            this.Hate = hate;
            this.HateThreatening = hateThreatening;
            this.SelfHarmInstructions = selfHarmInstructions;
            this.SelfHarm = selfHarm;
            this.SelfHarmIntent = selfHarmIntent;
            this.SexualMinors = sexualMinors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModerationConfig" /> class.
        /// </summary>
        public ModerationConfig()
        {
        }
    }
}