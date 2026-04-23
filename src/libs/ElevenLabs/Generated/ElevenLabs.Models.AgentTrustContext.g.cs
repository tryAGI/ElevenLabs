
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The trust context in which the agent operates.<br/>
    /// UNKNOWN: not yet classified (existing agents created before this feature).<br/>
    /// LOW: serves untrusted external participants (e.g. customer support, sales) —<br/>
    ///      outputs should be vetted and tool access scoped.<br/>
    /// HIGH: serves the owner (e.g. personal assistant) — full tool access is appropriate.<br/>
    /// Default Value: unknown
    /// </summary>
    public enum AgentTrustContext
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentTrustContextExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTrustContext value)
        {
            return value switch
            {
                AgentTrustContext.High => "high",
                AgentTrustContext.Low => "low",
                AgentTrustContext.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTrustContext? ToEnum(string value)
        {
            return value switch
            {
                "high" => AgentTrustContext.High,
                "low" => AgentTrustContext.Low,
                "unknown" => AgentTrustContext.Unknown,
                _ => null,
            };
        }
    }
}