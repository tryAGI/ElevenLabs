
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ListCampaignCallsStage
    {
        /// <summary>
        ///
        /// </summary>
        Delivered,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Queued,
        /// <summary>
        ///
        /// </summary>
        Read,
        /// <summary>
        ///
        /// </summary>
        Replied,
        /// <summary>
        ///
        /// </summary>
        Sent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCampaignCallsStageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCampaignCallsStage value)
        {
            return value switch
            {
                ListCampaignCallsStage.Delivered => "delivered",
                ListCampaignCallsStage.Failed => "failed",
                ListCampaignCallsStage.Queued => "queued",
                ListCampaignCallsStage.Read => "read",
                ListCampaignCallsStage.Replied => "replied",
                ListCampaignCallsStage.Sent => "sent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCampaignCallsStage? ToEnum(string value)
        {
            return value switch
            {
                "delivered" => ListCampaignCallsStage.Delivered,
                "failed" => ListCampaignCallsStage.Failed,
                "queued" => ListCampaignCallsStage.Queued,
                "read" => ListCampaignCallsStage.Read,
                "replied" => ListCampaignCallsStage.Replied,
                "sent" => ListCampaignCallsStage.Sent,
                _ => null,
            };
        }
    }
}