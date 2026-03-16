
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum TelephonyDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Inbound,
        /// <summary>
        /// 
        /// </summary>
        Outbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TelephonyDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TelephonyDirection value)
        {
            return value switch
            {
                TelephonyDirection.Inbound => "inbound",
                TelephonyDirection.Outbound => "outbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TelephonyDirection? ToEnum(string value)
        {
            return value switch
            {
                "inbound" => TelephonyDirection.Inbound,
                "outbound" => TelephonyDirection.Outbound,
                _ => null,
            };
        }
    }
}