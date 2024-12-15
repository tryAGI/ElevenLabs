
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModerationStatusResponseModelSafetyStatus
    {
        /// <summary>
        /// 
        /// </summary>
        AppealApproved,
        /// <summary>
        /// 
        /// </summary>
        AppealDenied,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModerationStatusResponseModelSafetyStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModerationStatusResponseModelSafetyStatus value)
        {
            return value switch
            {
                ModerationStatusResponseModelSafetyStatus.AppealApproved => "appeal_approved",
                ModerationStatusResponseModelSafetyStatus.AppealDenied => "appeal_denied",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModerationStatusResponseModelSafetyStatus? ToEnum(string value)
        {
            return value switch
            {
                "appeal_approved" => ModerationStatusResponseModelSafetyStatus.AppealApproved,
                "appeal_denied" => ModerationStatusResponseModelSafetyStatus.AppealDenied,
                _ => null,
            };
        }
    }
}