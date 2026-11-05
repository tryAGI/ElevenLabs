
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Why a phone assignment is currently inactive.
    /// </summary>
    public enum SMBPhoneAssignmentDeactivationReason
    {
        /// <summary>
        ///
        /// </summary>
        NoEntitlement,
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
    public static class SMBPhoneAssignmentDeactivationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBPhoneAssignmentDeactivationReason value)
        {
            return value switch
            {
                SMBPhoneAssignmentDeactivationReason.NoEntitlement => "no_entitlement",
                SMBPhoneAssignmentDeactivationReason.TierDowngrade => "tier_downgrade",
                SMBPhoneAssignmentDeactivationReason.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBPhoneAssignmentDeactivationReason? ToEnum(string value)
        {
            return value switch
            {
                "no_entitlement" => SMBPhoneAssignmentDeactivationReason.NoEntitlement,
                "tier_downgrade" => SMBPhoneAssignmentDeactivationReason.TierDowngrade,
                "user" => SMBPhoneAssignmentDeactivationReason.User,
                _ => null,
            };
        }
    }
}