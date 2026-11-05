
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SMBAgentTarget
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
    public static class SMBAgentTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBAgentTarget value)
        {
            return value switch
            {
                SMBAgentTarget.Assistant => "assistant",
                SMBAgentTarget.CustomerFacing => "customer_facing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBAgentTarget? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => SMBAgentTarget.Assistant,
                "customer_facing" => SMBAgentTarget.CustomerFacing,
                _ => null,
            };
        }
    }
}