
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentConfig
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
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment")]
        public global::ElevenLabs.ThresholdGuardrail? Harassment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_harm")]
        public global::ElevenLabs.ThresholdGuardrail? SelfHarm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profanity")]
        public global::ElevenLabs.ThresholdGuardrail? Profanity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("religion_or_politics")]
        public global::ElevenLabs.ThresholdGuardrail? ReligionOrPolitics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medical_and_legal_information")]
        public global::ElevenLabs.ThresholdGuardrail? MedicalAndLegalInformation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentConfig" /> class.
        /// </summary>
        /// <param name="sexual"></param>
        /// <param name="violence"></param>
        /// <param name="harassment"></param>
        /// <param name="selfHarm"></param>
        /// <param name="profanity"></param>
        /// <param name="religionOrPolitics"></param>
        /// <param name="medicalAndLegalInformation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentConfig(
            global::ElevenLabs.ThresholdGuardrail? sexual,
            global::ElevenLabs.ThresholdGuardrail? violence,
            global::ElevenLabs.ThresholdGuardrail? harassment,
            global::ElevenLabs.ThresholdGuardrail? selfHarm,
            global::ElevenLabs.ThresholdGuardrail? profanity,
            global::ElevenLabs.ThresholdGuardrail? religionOrPolitics,
            global::ElevenLabs.ThresholdGuardrail? medicalAndLegalInformation)
        {
            this.Sexual = sexual;
            this.Violence = violence;
            this.Harassment = harassment;
            this.SelfHarm = selfHarm;
            this.Profanity = profanity;
            this.ReligionOrPolitics = religionOrPolitics;
            this.MedicalAndLegalInformation = medicalAndLegalInformation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentConfig" /> class.
        /// </summary>
        public ContentConfig()
        {
        }
    }
}