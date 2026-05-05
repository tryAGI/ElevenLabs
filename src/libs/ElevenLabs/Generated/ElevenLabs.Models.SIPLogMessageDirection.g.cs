
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum SIPLogMessageDirection
    {
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        Out,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SIPLogMessageDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPLogMessageDirection value)
        {
            return value switch
            {
                SIPLogMessageDirection.In => "in",
                SIPLogMessageDirection.Out => "out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPLogMessageDirection? ToEnum(string value)
        {
            return value switch
            {
                "in" => SIPLogMessageDirection.In,
                "out" => SIPLogMessageDirection.Out,
                _ => null,
            };
        }
    }
}