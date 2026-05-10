
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
        public global::ElevenLabs.ContentThresholdGuardrail? Sexual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("violence")]
        public global::ElevenLabs.ContentThresholdGuardrail? Violence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harassment")]
        public global::ElevenLabs.ContentThresholdGuardrail? Harassment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self_harm")]
        public global::ElevenLabs.ContentThresholdGuardrail? SelfHarm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profanity")]
        public global::ElevenLabs.ContentThresholdGuardrail? Profanity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("religion_or_politics")]
        public global::ElevenLabs.ContentThresholdGuardrail? ReligionOrPolitics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("medical_and_legal_information")]
        public global::ElevenLabs.ContentThresholdGuardrail? MedicalAndLegalInformation { get; set; }

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
            global::ElevenLabs.ContentThresholdGuardrail? sexual,
            global::ElevenLabs.ContentThresholdGuardrail? violence,
            global::ElevenLabs.ContentThresholdGuardrail? harassment,
            global::ElevenLabs.ContentThresholdGuardrail? selfHarm,
            global::ElevenLabs.ContentThresholdGuardrail? profanity,
            global::ElevenLabs.ContentThresholdGuardrail? religionOrPolitics,
            global::ElevenLabs.ContentThresholdGuardrail? medicalAndLegalInformation)
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