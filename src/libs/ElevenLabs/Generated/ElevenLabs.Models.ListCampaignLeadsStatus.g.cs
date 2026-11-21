
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ListCampaignLeadsStatus
    {
        /// <summary>
        ///
        /// </summary>
        Finished,
        /// <summary>
        ///
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCampaignLeadsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCampaignLeadsStatus value)
        {
            return value switch
            {
                ListCampaignLeadsStatus.Finished => "finished",
                ListCampaignLeadsStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCampaignLeadsStatus? ToEnum(string value)
        {
            return value switch
            {
                "finished" => ListCampaignLeadsStatus.Finished,
                "in_progress" => ListCampaignLeadsStatus.InProgress,
                _ => null,
            };
        }
    }
}