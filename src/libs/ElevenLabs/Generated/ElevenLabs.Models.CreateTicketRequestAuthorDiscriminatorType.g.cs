
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTicketRequestAuthorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        HumanAgent,
        /// <summary>
        ///
        /// </summary>
        Requester,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTicketRequestAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTicketRequestAuthorDiscriminatorType value)
        {
            return value switch
            {
                CreateTicketRequestAuthorDiscriminatorType.HumanAgent => "human_agent",
                CreateTicketRequestAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTicketRequestAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "human_agent" => CreateTicketRequestAuthorDiscriminatorType.HumanAgent,
                "requester" => CreateTicketRequestAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}