
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTicketMessageRequestAuthorDiscriminatorType
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
    public static class CreateTicketMessageRequestAuthorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTicketMessageRequestAuthorDiscriminatorType value)
        {
            return value switch
            {
                CreateTicketMessageRequestAuthorDiscriminatorType.HumanAgent => "human_agent",
                CreateTicketMessageRequestAuthorDiscriminatorType.Requester => "requester",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTicketMessageRequestAuthorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "human_agent" => CreateTicketMessageRequestAuthorDiscriminatorType.HumanAgent,
                "requester" => CreateTicketMessageRequestAuthorDiscriminatorType.Requester,
                _ => null,
            };
        }
    }
}