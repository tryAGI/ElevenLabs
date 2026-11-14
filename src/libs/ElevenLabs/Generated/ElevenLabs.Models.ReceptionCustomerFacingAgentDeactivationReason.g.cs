
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Why a receptionist is currently inactive (live calls disabled).
    /// </summary>
    public enum ReceptionCustomerFacingAgentDeactivationReason
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
    public static class ReceptionCustomerFacingAgentDeactivationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionCustomerFacingAgentDeactivationReason value)
        {
            return value switch
            {
                ReceptionCustomerFacingAgentDeactivationReason.TierDowngrade => "tier_downgrade",
                ReceptionCustomerFacingAgentDeactivationReason.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionCustomerFacingAgentDeactivationReason? ToEnum(string value)
        {
            return value switch
            {
                "tier_downgrade" => ReceptionCustomerFacingAgentDeactivationReason.TierDowngrade,
                "user" => ReceptionCustomerFacingAgentDeactivationReason.User,
                _ => null,
            };
        }
    }
}