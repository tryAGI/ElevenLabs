
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CampaignStatus
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Attention,
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Paused,
        /// <summary>
        ///
        /// </summary>
        Stopped,
        /// <summary>
        ///
        /// </summary>
        Stopping,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignStatus value)
        {
            return value switch
            {
                CampaignStatus.Active => "active",
                CampaignStatus.Attention => "attention",
                CampaignStatus.Completed => "completed",
                CampaignStatus.Failed => "failed",
                CampaignStatus.Paused => "paused",
                CampaignStatus.Stopped => "stopped",
                CampaignStatus.Stopping => "stopping",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CampaignStatus.Active,
                "attention" => CampaignStatus.Attention,
                "completed" => CampaignStatus.Completed,
                "failed" => CampaignStatus.Failed,
                "paused" => CampaignStatus.Paused,
                "stopped" => CampaignStatus.Stopped,
                "stopping" => CampaignStatus.Stopping,
                _ => null,
            };
        }
    }
}