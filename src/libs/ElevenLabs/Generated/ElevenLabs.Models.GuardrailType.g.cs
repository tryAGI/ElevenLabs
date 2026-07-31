
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum GuardrailType
    {
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Guardrail,
        /// <summary>
        /// 
        /// </summary>
        Harassment,
        /// <summary>
        /// 
        /// </summary>
        HarassmentThreatening,
        /// <summary>
        /// 
        /// </summary>
        Hate,
        /// <summary>
        /// 
        /// </summary>
        HateThreatening,
        /// <summary>
        /// 
        /// </summary>
        MedicalAndLegal,
        /// <summary>
        /// 
        /// </summary>
        Profanity,
        /// <summary>
        /// 
        /// </summary>
        PromptInjection,
        /// <summary>
        /// 
        /// </summary>
        ReligionOrPolitics,
        /// <summary>
        /// 
        /// </summary>
        SelfHarm,
        /// <summary>
        /// 
        /// </summary>
        SelfHarmInstructions,
        /// <summary>
        /// 
        /// </summary>
        SelfHarmIntent,
        /// <summary>
        /// 
        /// </summary>
        Sexual,
        /// <summary>
        /// 
        /// </summary>
        SexualMinors,
        /// <summary>
        /// 
        /// </summary>
        Violence,
        /// <summary>
        /// 
        /// </summary>
        ViolenceGraphic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GuardrailTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GuardrailType value)
        {
            return value switch
            {
                GuardrailType.Custom => "custom",
                GuardrailType.Guardrail => "guardrail",
                GuardrailType.Harassment => "harassment",
                GuardrailType.HarassmentThreatening => "harassment_threatening",
                GuardrailType.Hate => "hate",
                GuardrailType.HateThreatening => "hate_threatening",
                GuardrailType.MedicalAndLegal => "medical_and_legal",
                GuardrailType.Profanity => "profanity",
                GuardrailType.PromptInjection => "prompt_injection",
                GuardrailType.ReligionOrPolitics => "religion_or_politics",
                GuardrailType.SelfHarm => "self_harm",
                GuardrailType.SelfHarmInstructions => "self_harm_instructions",
                GuardrailType.SelfHarmIntent => "self_harm_intent",
                GuardrailType.Sexual => "sexual",
                GuardrailType.SexualMinors => "sexual_minors",
                GuardrailType.Violence => "violence",
                GuardrailType.ViolenceGraphic => "violence_graphic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GuardrailType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GuardrailType.Custom,
                "guardrail" => GuardrailType.Guardrail,
                "harassment" => GuardrailType.Harassment,
                "harassment_threatening" => GuardrailType.HarassmentThreatening,
                "hate" => GuardrailType.Hate,
                "hate_threatening" => GuardrailType.HateThreatening,
                "medical_and_legal" => GuardrailType.MedicalAndLegal,
                "profanity" => GuardrailType.Profanity,
                "prompt_injection" => GuardrailType.PromptInjection,
                "religion_or_politics" => GuardrailType.ReligionOrPolitics,
                "self_harm" => GuardrailType.SelfHarm,
                "self_harm_instructions" => GuardrailType.SelfHarmInstructions,
                "self_harm_intent" => GuardrailType.SelfHarmIntent,
                "sexual" => GuardrailType.Sexual,
                "sexual_minors" => GuardrailType.SexualMinors,
                "violence" => GuardrailType.Violence,
                "violence_graphic" => GuardrailType.ViolenceGraphic,
                _ => null,
            };
        }
    }
}