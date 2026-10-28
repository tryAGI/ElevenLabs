
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Discriminator for the bookable-service shape.<br/>
    /// - ``CLASSIC``: staff-delivered service (haircut, consultation, massage, ...).<br/>
    /// - ``RENTAL``: asset-based reservation (court, room, equipment).<br/>
    /// - ``GROUP``: multi-participant session (class, workshop, tour).<br/>
    /// Default Value: classic
    /// </summary>
    public enum SMBServiceKind
    {
        /// <summary>
        ///
        /// </summary>
        Classic,
        /// <summary>
        ///
        /// </summary>
        Group,
        /// <summary>
        ///
        /// </summary>
        Rental,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMBServiceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBServiceKind value)
        {
            return value switch
            {
                SMBServiceKind.Classic => "classic",
                SMBServiceKind.Group => "group",
                SMBServiceKind.Rental => "rental",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBServiceKind? ToEnum(string value)
        {
            return value switch
            {
                "classic" => SMBServiceKind.Classic,
                "group" => SMBServiceKind.Group,
                "rental" => SMBServiceKind.Rental,
                _ => null,
            };
        }
    }
}