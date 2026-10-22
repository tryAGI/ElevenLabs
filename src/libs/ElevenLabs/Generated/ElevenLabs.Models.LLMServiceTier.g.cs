
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request-time processing tier for a model.<br/>
    /// STANDARD: default price and throughput.<br/>
    /// FAST: pays a per-token price premium for higher throughput / lower latency.<br/>
    ///     See OpenAI's fast mode: https://openai.com/api-fast-mode/<br/>
    /// Default Value: standard
    /// </summary>
    public enum LLMServiceTier
    {
        /// <summary>
        /// https://openai.com/api-fast-mode/
        /// </summary>
        Fast,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMServiceTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMServiceTier value)
        {
            return value switch
            {
                LLMServiceTier.Fast => "fast",
                LLMServiceTier.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMServiceTier? ToEnum(string value)
        {
            return value switch
            {
                "fast" => LLMServiceTier.Fast,
                "standard" => LLMServiceTier.Standard,
                _ => null,
            };
        }
    }
}