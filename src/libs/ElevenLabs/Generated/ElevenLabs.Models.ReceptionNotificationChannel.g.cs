
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ReceptionNotificationChannel
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
    public static class ReceptionNotificationChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionNotificationChannel value)
        {
            return value switch
            {
                ReceptionNotificationChannel.Email => "email",
                ReceptionNotificationChannel.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionNotificationChannel? ToEnum(string value)
        {
            return value switch
            {
                "email" => ReceptionNotificationChannel.Email,
                "sms" => ReceptionNotificationChannel.Sms,
                _ => null,
            };
        }
    }
}