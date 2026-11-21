
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// What a service books.<br/>
    /// - `classic`: a staff-delivered service (haircut, consultation, massage, ...).<br/>
    /// - `rental`: an asset reservation (court, room, equipment).<br/>
    /// - `group`: seats in a multi-participant session (class, workshop, tour).<br/>
    /// Default Value: classic
    /// </summary>
    public enum ReceptionServiceKind
    {
        /// <summary>
        /// a staff-delivered service (haircut, consultation, massage, ...).
        /// </summary>
        Classic,
        /// <summary>
        /// seats in a multi-participant session (class, workshop, tour).
        /// </summary>
        Group,
        /// <summary>
        /// an asset reservation (court, room, equipment).
        /// </summary>
        Rental,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReceptionServiceKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionServiceKind value)
        {
            return value switch
            {
                ReceptionServiceKind.Classic => "classic",
                ReceptionServiceKind.Group => "group",
                ReceptionServiceKind.Rental => "rental",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionServiceKind? ToEnum(string value)
        {
            return value switch
            {
                "classic" => ReceptionServiceKind.Classic,
                "group" => ReceptionServiceKind.Group,
                "rental" => ReceptionServiceKind.Rental,
                _ => null,
            };
        }
    }
}