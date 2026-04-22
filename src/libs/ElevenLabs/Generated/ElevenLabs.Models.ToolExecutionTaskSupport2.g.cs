
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolExecutionTaskSupport2
    {
        /// <summary>
        /// 
        /// </summary>
        Forbidden,
        /// <summary>
        /// 
        /// </summary>
        Optional,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolExecutionTaskSupport2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolExecutionTaskSupport2 value)
        {
            return value switch
            {
                ToolExecutionTaskSupport2.Forbidden => "forbidden",
                ToolExecutionTaskSupport2.Optional => "optional",
                ToolExecutionTaskSupport2.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolExecutionTaskSupport2? ToEnum(string value)
        {
            return value switch
            {
                "forbidden" => ToolExecutionTaskSupport2.Forbidden,
                "optional" => ToolExecutionTaskSupport2.Optional,
                "required" => ToolExecutionTaskSupport2.Required,
                _ => null,
            };
        }
    }
}