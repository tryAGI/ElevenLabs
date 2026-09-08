
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolExecutionTaskSupport
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
    public static class ToolExecutionTaskSupportExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolExecutionTaskSupport value)
        {
            return value switch
            {
                ToolExecutionTaskSupport.Forbidden => "forbidden",
                ToolExecutionTaskSupport.Optional => "optional",
                ToolExecutionTaskSupport.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolExecutionTaskSupport? ToEnum(string value)
        {
            return value switch
            {
                "forbidden" => ToolExecutionTaskSupport.Forbidden,
                "optional" => ToolExecutionTaskSupport.Optional,
                "required" => ToolExecutionTaskSupport.Required,
                _ => null,
            };
        }
    }
}