
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The source to extract the value from. Currently only 'response' is supported.<br/>
    /// Default Value: response
    /// </summary>
    public enum DynamicVariableAssignmentSource
    {
        /// <summary>
        /// 
        /// </summary>
        Response,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DynamicVariableAssignmentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DynamicVariableAssignmentSource value)
        {
            return value switch
            {
                DynamicVariableAssignmentSource.Response => "response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DynamicVariableAssignmentSource? ToEnum(string value)
        {
            return value switch
            {
                "response" => DynamicVariableAssignmentSource.Response,
                _ => null,
            };
        }
    }
}