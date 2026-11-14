
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Whether to wait for the reply, or keep going and get it later in the conversation.<br/>
    /// Default Value: immediate
    /// </summary>
    public enum SubAgentInputExecutionMode
    {
        /// <summary>
        ///
        /// </summary>
        Async,
        /// <summary>
        ///
        /// </summary>
        Immediate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubAgentInputExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubAgentInputExecutionMode value)
        {
            return value switch
            {
                SubAgentInputExecutionMode.Async => "async",
                SubAgentInputExecutionMode.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubAgentInputExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => SubAgentInputExecutionMode.Async,
                "immediate" => SubAgentInputExecutionMode.Immediate,
                _ => null,
            };
        }
    }
}