
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ReceptionAgentTarget
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        CustomerFacing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReceptionAgentTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionAgentTarget value)
        {
            return value switch
            {
                ReceptionAgentTarget.Assistant => "assistant",
                ReceptionAgentTarget.CustomerFacing => "customer_facing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionAgentTarget? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ReceptionAgentTarget.Assistant,
                "customer_facing" => ReceptionAgentTarget.CustomerFacing,
                _ => null,
            };
        }
    }
}