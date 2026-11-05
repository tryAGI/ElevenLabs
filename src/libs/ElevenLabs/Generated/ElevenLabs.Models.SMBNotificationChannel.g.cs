
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SMBNotificationChannel
    {
        /// <summary>
        ///
        /// </summary>
        Email,
        /// <summary>
        ///
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMBNotificationChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBNotificationChannel value)
        {
            return value switch
            {
                SMBNotificationChannel.Email => "email",
                SMBNotificationChannel.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBNotificationChannel? ToEnum(string value)
        {
            return value switch
            {
                "email" => SMBNotificationChannel.Email,
                "sms" => SMBNotificationChannel.Sms,
                _ => null,
            };
        }
    }
}