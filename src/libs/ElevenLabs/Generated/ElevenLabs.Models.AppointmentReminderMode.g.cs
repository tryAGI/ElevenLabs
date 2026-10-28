
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AppointmentReminderMode
    {
        /// <summary>
        ///
        /// </summary>
        Confirmation,
        /// <summary>
        ///
        /// </summary>
        Reminder,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppointmentReminderModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppointmentReminderMode value)
        {
            return value switch
            {
                AppointmentReminderMode.Confirmation => "confirmation",
                AppointmentReminderMode.Reminder => "reminder",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppointmentReminderMode? ToEnum(string value)
        {
            return value switch
            {
                "confirmation" => AppointmentReminderMode.Confirmation,
                "reminder" => AppointmentReminderMode.Reminder,
                _ => null,
            };
        }
    }
}