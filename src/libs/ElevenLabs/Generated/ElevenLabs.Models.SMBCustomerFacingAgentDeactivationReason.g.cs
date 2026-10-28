
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Why a receptionist is currently inactive (live calls disabled).
    /// </summary>
    public enum SMBCustomerFacingAgentDeactivationReason
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
    public static class SMBCustomerFacingAgentDeactivationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBCustomerFacingAgentDeactivationReason value)
        {
            return value switch
            {
                SMBCustomerFacingAgentDeactivationReason.TierDowngrade => "tier_downgrade",
                SMBCustomerFacingAgentDeactivationReason.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBCustomerFacingAgentDeactivationReason? ToEnum(string value)
        {
            return value switch
            {
                "tier_downgrade" => SMBCustomerFacingAgentDeactivationReason.TierDowngrade,
                "user" => SMBCustomerFacingAgentDeactivationReason.User,
                _ => null,
            };
        }
    }
}