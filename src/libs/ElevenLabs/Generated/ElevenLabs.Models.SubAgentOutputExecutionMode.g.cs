
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Whether to wait for the reply, or keep going and get it later in the conversation.<br/>
    /// Default Value: immediate
    /// </summary>
    public enum SubAgentOutputExecutionMode
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
    public static class SubAgentOutputExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubAgentOutputExecutionMode value)
        {
            return value switch
            {
                SubAgentOutputExecutionMode.Async => "async",
                SubAgentOutputExecutionMode.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubAgentOutputExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => SubAgentOutputExecutionMode.Async,
                "immediate" => SubAgentOutputExecutionMode.Immediate,
                _ => null,
            };
        }
    }
}