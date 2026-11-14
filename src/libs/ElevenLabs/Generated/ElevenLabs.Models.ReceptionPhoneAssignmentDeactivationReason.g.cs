
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Why a phone assignment is currently inactive.
    /// </summary>
    public enum ReceptionPhoneAssignmentDeactivationReason
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
    public static class ReceptionPhoneAssignmentDeactivationReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionPhoneAssignmentDeactivationReason value)
        {
            return value switch
            {
                ReceptionPhoneAssignmentDeactivationReason.NoEntitlement => "no_entitlement",
                ReceptionPhoneAssignmentDeactivationReason.TierDowngrade => "tier_downgrade",
                ReceptionPhoneAssignmentDeactivationReason.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionPhoneAssignmentDeactivationReason? ToEnum(string value)
        {
            return value switch
            {
                "no_entitlement" => ReceptionPhoneAssignmentDeactivationReason.NoEntitlement,
                "tier_downgrade" => ReceptionPhoneAssignmentDeactivationReason.TierDowngrade,
                "user" => ReceptionPhoneAssignmentDeactivationReason.User,
                _ => null,
            };
        }
    }
}