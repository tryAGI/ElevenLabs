
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: call_real_tool
    /// </summary>
    public enum MockNoMatchBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        CallRealTool,
        /// <summary>
        /// 
        /// </summary>
        RaiseError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MockNoMatchBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MockNoMatchBehavior value)
        {
            return value switch
            {
                MockNoMatchBehavior.CallRealTool => "call_real_tool",
                MockNoMatchBehavior.RaiseError => "raise_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MockNoMatchBehavior? ToEnum(string value)
        {
            return value switch
            {
                "call_real_tool" => MockNoMatchBehavior.CallRealTool,
                "raise_error" => MockNoMatchBehavior.RaiseError,
                _ => null,
            };
        }
    }
}