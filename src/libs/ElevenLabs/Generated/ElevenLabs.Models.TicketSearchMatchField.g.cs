
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TicketSearchMatchField
    {
        /// <summary>
        ///
        /// </summary>
        Comment,
        /// <summary>
        ///
        /// </summary>
        Description,
        /// <summary>
        ///
        /// </summary>
        Title,
        /// <summary>
        ///
        /// </summary>
        TurnComment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TicketSearchMatchFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TicketSearchMatchField value)
        {
            return value switch
            {
                TicketSearchMatchField.Comment => "comment",
                TicketSearchMatchField.Description => "description",
                TicketSearchMatchField.Title => "title",
                TicketSearchMatchField.TurnComment => "turn_comment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TicketSearchMatchField? ToEnum(string value)
        {
            return value switch
            {
                "comment" => TicketSearchMatchField.Comment,
                "description" => TicketSearchMatchField.Description,
                "title" => TicketSearchMatchField.Title,
                "turn_comment" => TicketSearchMatchField.TurnComment,
                _ => null,
            };
        }
    }
}