
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Why a location is currently inactive.
    /// </summary>
    public enum ReceptionLocationDeactivationReason
    {
        /// <summary>
        ///
        /// </summary>
        TierDowngrade,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReceptionLocationDeactivationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionLocationDeactivationReason value)
        {
            return value switch
            {
                ReceptionLocationDeactivationReason.TierDowngrade => "tier_downgrade",
                ReceptionLocationDeactivationReason.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionLocationDeactivationReason? ToEnum(string value)
        {
            return value switch
            {
                "tier_downgrade" => ReceptionLocationDeactivationReason.TierDowngrade,
                "user" => ReceptionLocationDeactivationReason.User,
                _ => null,
            };
        }
    }
}