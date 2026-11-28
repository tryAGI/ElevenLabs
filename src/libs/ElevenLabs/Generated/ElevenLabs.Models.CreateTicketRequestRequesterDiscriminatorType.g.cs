
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateTicketRequestRequesterDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Email,
        /// <summary>
        ///
        /// </summary>
        Slack,
        /// <summary>
        ///
        /// </summary>
        UserId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTicketRequestRequesterDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTicketRequestRequesterDiscriminatorType value)
        {
            return value switch
            {
                CreateTicketRequestRequesterDiscriminatorType.Email => "email",
                CreateTicketRequestRequesterDiscriminatorType.Slack => "slack",
                CreateTicketRequestRequesterDiscriminatorType.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTicketRequestRequesterDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "email" => CreateTicketRequestRequesterDiscriminatorType.Email,
                "slack" => CreateTicketRequestRequesterDiscriminatorType.Slack,
                "user_id" => CreateTicketRequestRequesterDiscriminatorType.UserId,
                _ => null,
            };
        }
    }
}