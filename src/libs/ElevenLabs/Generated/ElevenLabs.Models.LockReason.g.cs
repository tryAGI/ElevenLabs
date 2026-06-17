
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum LockReason
    {
        /// <summary>
        /// 
        /// </summary>
        ExposedPublicly,
        /// <summary>
        /// 
        /// </summary>
        SelfDisabled,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionDowngrade,
        /// <summary>
        /// 
        /// </summary>
        TrialEnded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LockReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LockReason value)
        {
            return value switch
            {
                LockReason.ExposedPublicly => "exposed_publicly",
                LockReason.SelfDisabled => "self_disabled",
                LockReason.SubscriptionDowngrade => "subscription_downgrade",
                LockReason.TrialEnded => "trial_ended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LockReason? ToEnum(string value)
        {
            return value switch
            {
                "exposed_publicly" => LockReason.ExposedPublicly,
                "self_disabled" => LockReason.SelfDisabled,
                "subscription_downgrade" => LockReason.SubscriptionDowngrade,
                "trial_ended" => LockReason.TrialEnded,
                _ => null,
            };
        }
    }
}