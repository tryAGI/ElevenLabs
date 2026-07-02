
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: allow
    /// </summary>
    public enum ToolInterruptionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        DisableDuringTool,
        /// <summary>
        /// 
        /// </summary>
        DisableDuringToolAndTurn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolInterruptionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolInterruptionMode value)
        {
            return value switch
            {
                ToolInterruptionMode.Allow => "allow",
                ToolInterruptionMode.DisableDuringTool => "disable_during_tool",
                ToolInterruptionMode.DisableDuringToolAndTurn => "disable_during_tool_and_turn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolInterruptionMode? ToEnum(string value)
        {
            return value switch
            {
                "allow" => ToolInterruptionMode.Allow,
                "disable_during_tool" => ToolInterruptionMode.DisableDuringTool,
                "disable_during_tool_and_turn" => ToolInterruptionMode.DisableDuringToolAndTurn,
                _ => null,
            };
        }
    }
}