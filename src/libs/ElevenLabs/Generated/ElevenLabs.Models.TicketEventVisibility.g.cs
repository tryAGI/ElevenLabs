
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketEventVisibility
    {
        /// <summary>
        ///
        /// </summary>
        Internal,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TicketEventVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketEventVisibility value)
        {
            return value switch
            {
                TicketEventVisibility.Internal => "internal",
                TicketEventVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketEventVisibility? ToEnum(string value)
        {
            return value switch
            {
                "internal" => TicketEventVisibility.Internal,
                "public" => TicketEventVisibility.Public,
                _ => null,
            };
        }
    }
}