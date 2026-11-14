
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum TerminalDisposition
    {
        /// <summary>
        ///
        /// </summary>
        AttemptCeilingReached,
        /// <summary>
        ///
        /// </summary>
        CallbackCeilingReached,
        /// <summary>
        ///
        /// </summary>
        CallbackTimeInvalid,
        /// <summary>
        ///
        /// </summary>
        CampaignEnded,
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
        Removed,
        /// <summary>
        ///
        /// </summary>
        Suppressed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TerminalDispositionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TerminalDisposition value)
        {
            return value switch
            {
                TerminalDisposition.AttemptCeilingReached => "attempt_ceiling_reached",
                TerminalDisposition.CallbackCeilingReached => "callback_ceiling_reached",
                TerminalDisposition.CallbackTimeInvalid => "callback_time_invalid",
                TerminalDisposition.CampaignEnded => "campaign_ended",
                TerminalDisposition.Cancelled => "cancelled",
                TerminalDisposition.Completed => "completed",
                TerminalDisposition.CouldntProcess => "couldnt_process",
                TerminalDisposition.DoNotCall => "do_not_call",
                TerminalDisposition.PermissionDeclined => "permission_declined",
                TerminalDisposition.PermissionExpired => "permission_expired",
                TerminalDisposition.PermissionNotGranted => "permission_not_granted",
                TerminalDisposition.PermissionRequestBlocked => "permission_request_blocked",
                TerminalDisposition.RedirectCeilingReached => "redirect_ceiling_reached",
                TerminalDisposition.RedirectNumberInvalid => "redirect_number_invalid",
                TerminalDisposition.Removed => "removed",
                TerminalDisposition.Suppressed => "suppressed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TerminalDisposition? ToEnum(string value)
        {
            return value switch
            {
                "attempt_ceiling_reached" => TerminalDisposition.AttemptCeilingReached,
                "callback_ceiling_reached" => TerminalDisposition.CallbackCeilingReached,
                "callback_time_invalid" => TerminalDisposition.CallbackTimeInvalid,
                "campaign_ended" => TerminalDisposition.CampaignEnded,
                "cancelled" => TerminalDisposition.Cancelled,
                "completed" => TerminalDisposition.Completed,
                "couldnt_process" => TerminalDisposition.CouldntProcess,
                "do_not_call" => TerminalDisposition.DoNotCall,
                "permission_declined" => TerminalDisposition.PermissionDeclined,
                "permission_expired" => TerminalDisposition.PermissionExpired,
                "permission_not_granted" => TerminalDisposition.PermissionNotGranted,
                "permission_request_blocked" => TerminalDisposition.PermissionRequestBlocked,
                "redirect_ceiling_reached" => TerminalDisposition.RedirectCeilingReached,
                "redirect_number_invalid" => TerminalDisposition.RedirectNumberInvalid,
                "removed" => TerminalDisposition.Removed,
                "suppressed" => TerminalDisposition.Suppressed,
                _ => null,
            };
        }
    }
}