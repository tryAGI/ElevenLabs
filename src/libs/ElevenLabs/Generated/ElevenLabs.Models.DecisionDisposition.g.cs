
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How a settled call's decision left its lead.
    /// </summary>
    public enum DecisionDisposition
    {
        /// <summary>
        ///
        /// </summary>
        AttemptCeilingReached,
        /// <summary>
        ///
        /// </summary>
        Attention,
        /// <summary>
        ///
        /// </summary>
        CallbackCeilingReached,
        /// <summary>
        ///
        /// </summary>
        CallbackQueued,
        /// <summary>
        ///
        /// </summary>
        CallbackTimeInvalid,
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        CouldntProcess,
        /// <summary>
        ///
        /// </summary>
        DoNotCall,
        /// <summary>
        ///
        /// </summary>
        PermissionDeclined,
        /// <summary>
        ///
        /// </summary>
        PermissionExpired,
        /// <summary>
        ///
        /// </summary>
        PermissionNotGranted,
        /// <summary>
        ///
        /// </summary>
        PermissionRequestBlocked,
        /// <summary>
        ///
        /// </summary>
        RedirectCeilingReached,
        /// <summary>
        ///
        /// </summary>
        RedirectNumberInvalid,
        /// <summary>
        ///
        /// </summary>
        RedirectQueued,
        /// <summary>
        ///
        /// </summary>
        RetryQueued,
        /// <summary>
        ///
        /// </summary>
        Suppressed,
        /// <summary>
        ///
        /// </summary>
        SuppressedAfterStop,
        /// <summary>
        ///
        /// </summary>
        SuppressedDoNotCall,
        /// <summary>
        ///
        /// </summary>
        WindowSuspended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionDispositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionDisposition value)
        {
            return value switch
            {
                DecisionDisposition.AttemptCeilingReached => "attempt_ceiling_reached",
                DecisionDisposition.Attention => "attention",
                DecisionDisposition.CallbackCeilingReached => "callback_ceiling_reached",
                DecisionDisposition.CallbackQueued => "callback_queued",
                DecisionDisposition.CallbackTimeInvalid => "callback_time_invalid",
                DecisionDisposition.Cancelled => "cancelled",
                DecisionDisposition.Completed => "completed",
                DecisionDisposition.CouldntProcess => "couldnt_process",
                DecisionDisposition.DoNotCall => "do_not_call",
                DecisionDisposition.PermissionDeclined => "permission_declined",
                DecisionDisposition.PermissionExpired => "permission_expired",
                DecisionDisposition.PermissionNotGranted => "permission_not_granted",
                DecisionDisposition.PermissionRequestBlocked => "permission_request_blocked",
                DecisionDisposition.RedirectCeilingReached => "redirect_ceiling_reached",
                DecisionDisposition.RedirectNumberInvalid => "redirect_number_invalid",
                DecisionDisposition.RedirectQueued => "redirect_queued",
                DecisionDisposition.RetryQueued => "retry_queued",
                DecisionDisposition.Suppressed => "suppressed",
                DecisionDisposition.SuppressedAfterStop => "suppressed_after_stop",
                DecisionDisposition.SuppressedDoNotCall => "suppressed_do_not_call",
                DecisionDisposition.WindowSuspended => "window_suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionDisposition? ToEnum(string value)
        {
            return value switch
            {
                "attempt_ceiling_reached" => DecisionDisposition.AttemptCeilingReached,
                "attention" => DecisionDisposition.Attention,
                "callback_ceiling_reached" => DecisionDisposition.CallbackCeilingReached,
                "callback_queued" => DecisionDisposition.CallbackQueued,
                "callback_time_invalid" => DecisionDisposition.CallbackTimeInvalid,
                "cancelled" => DecisionDisposition.Cancelled,
                "completed" => DecisionDisposition.Completed,
                "couldnt_process" => DecisionDisposition.CouldntProcess,
                "do_not_call" => DecisionDisposition.DoNotCall,
                "permission_declined" => DecisionDisposition.PermissionDeclined,
                "permission_expired" => DecisionDisposition.PermissionExpired,
                "permission_not_granted" => DecisionDisposition.PermissionNotGranted,
                "permission_request_blocked" => DecisionDisposition.PermissionRequestBlocked,
                "redirect_ceiling_reached" => DecisionDisposition.RedirectCeilingReached,
                "redirect_number_invalid" => DecisionDisposition.RedirectNumberInvalid,
                "redirect_queued" => DecisionDisposition.RedirectQueued,
                "retry_queued" => DecisionDisposition.RetryQueued,
                "suppressed" => DecisionDisposition.Suppressed,
                "suppressed_after_stop" => DecisionDisposition.SuppressedAfterStop,
                "suppressed_do_not_call" => DecisionDisposition.SuppressedDoNotCall,
                "window_suspended" => DecisionDisposition.WindowSuspended,
                _ => null,
            };
        }
    }
}