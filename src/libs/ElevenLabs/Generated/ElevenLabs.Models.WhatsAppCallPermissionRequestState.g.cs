
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum WhatsAppCallPermissionRequestState
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        Blocked,
        /// <summary>
        ///
        /// </summary>
        Declined,
        /// <summary>
        ///
        /// </summary>
        Sent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhatsAppCallPermissionRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhatsAppCallPermissionRequestState value)
        {
            return value switch
            {
                WhatsAppCallPermissionRequestState.Accepted => "accepted",
                WhatsAppCallPermissionRequestState.Blocked => "blocked",
                WhatsAppCallPermissionRequestState.Declined => "declined",
                WhatsAppCallPermissionRequestState.Sent => "sent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhatsAppCallPermissionRequestState? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => WhatsAppCallPermissionRequestState.Accepted,
                "blocked" => WhatsAppCallPermissionRequestState.Blocked,
                "declined" => WhatsAppCallPermissionRequestState.Declined,
                "sent" => WhatsAppCallPermissionRequestState.Sent,
                _ => null,
            };
        }
    }
}