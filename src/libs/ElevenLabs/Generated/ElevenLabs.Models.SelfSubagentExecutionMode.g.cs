
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Whether to wait for the reply, or keep going and get it later in the conversation.<br/>
    /// Default Value: immediate
    /// </summary>
    public enum SelfSubagentExecutionMode
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
    public static class SelfSubagentExecutionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelfSubagentExecutionMode value)
        {
            return value switch
            {
                SelfSubagentExecutionMode.Async => "async",
                SelfSubagentExecutionMode.Immediate => "immediate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelfSubagentExecutionMode? ToEnum(string value)
        {
            return value switch
            {
                "async" => SelfSubagentExecutionMode.Async,
                "immediate" => SelfSubagentExecutionMode.Immediate,
                _ => null,
            };
        }
    }
}