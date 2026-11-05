
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Why a location is currently inactive.
    /// </summary>
    public enum SMBLocationDeactivationReason
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
    public static class SMBLocationDeactivationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBLocationDeactivationReason value)
        {
            return value switch
            {
                SMBLocationDeactivationReason.TierDowngrade => "tier_downgrade",
                SMBLocationDeactivationReason.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBLocationDeactivationReason? ToEnum(string value)
        {
            return value switch
            {
                "tier_downgrade" => SMBLocationDeactivationReason.TierDowngrade,
                "user" => SMBLocationDeactivationReason.User,
                _ => null,
            };
        }
    }
}