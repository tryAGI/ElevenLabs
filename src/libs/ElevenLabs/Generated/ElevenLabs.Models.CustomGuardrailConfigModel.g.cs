
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// LLM model to use for custom guardrail evaluation<br/>
    /// Default Value: gemini-2.5-flash-lite
    /// </summary>
    public enum CustomGuardrailConfigModel
    {
        /// <summary>
        /// 
        /// </summary>
        ClaudeHaiku45,
        /// <summary>
        /// 
        /// </summary>
        ClaudeSonnet46,
        /// <summary>
        /// 
        /// </summary>
        Gemini25Flash,
        /// <summary>
        /// 
        /// </summary>
        Gemini25FlashLite,
        /// <summary>
        /// 
        /// </summary>
        Gemini31FlashLite,
        /// <summary>
        /// 
        /// </summary>
        Gemini35Flash,
        /// <summary>
        /// 
        /// </summary>
        Gpt54Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt54Nano,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomGuardrailConfigModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomGuardrailConfigModel value)
        {
            return value switch
            {
                CustomGuardrailConfigModel.ClaudeHaiku45 => "claude-haiku-4-5",
                CustomGuardrailConfigModel.ClaudeSonnet46 => "claude-sonnet-4-6",
                CustomGuardrailConfigModel.Gemini25Flash => "gemini-2.5-flash",
                CustomGuardrailConfigModel.Gemini25FlashLite => "gemini-2.5-flash-lite",
                CustomGuardrailConfigModel.Gemini31FlashLite => "gemini-3.1-flash-lite",
                CustomGuardrailConfigModel.Gemini35Flash => "gemini-3.5-flash",
                CustomGuardrailConfigModel.Gpt54Mini => "gpt-5.4-mini",
                CustomGuardrailConfigModel.Gpt54Nano => "gpt-5.4-nano",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomGuardrailConfigModel? ToEnum(string value)
        {
            return value switch
            {
                "claude-haiku-4-5" => CustomGuardrailConfigModel.ClaudeHaiku45,
                "claude-sonnet-4-6" => CustomGuardrailConfigModel.ClaudeSonnet46,
                "gemini-2.5-flash" => CustomGuardrailConfigModel.Gemini25Flash,
                "gemini-2.5-flash-lite" => CustomGuardrailConfigModel.Gemini25FlashLite,
                "gemini-3.1-flash-lite" => CustomGuardrailConfigModel.Gemini31FlashLite,
                "gemini-3.5-flash" => CustomGuardrailConfigModel.Gemini35Flash,
                "gpt-5.4-mini" => CustomGuardrailConfigModel.Gpt54Mini,
                "gpt-5.4-nano" => CustomGuardrailConfigModel.Gpt54Nano,
                _ => null,
            };
        }
    }
}