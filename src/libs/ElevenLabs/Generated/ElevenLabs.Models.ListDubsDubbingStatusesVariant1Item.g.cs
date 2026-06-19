
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListDubsDubbingStatusesVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        Dubbed,
        /// <summary>
        /// 
        /// </summary>
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Preparing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDubsDubbingStatusesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDubsDubbingStatusesVariant1Item value)
        {
            return value switch
            {
                ListDubsDubbingStatusesVariant1Item.Dubbed => "dubbed",
                ListDubsDubbingStatusesVariant1Item.Dubbing => "dubbing",
                ListDubsDubbingStatusesVariant1Item.Failed => "failed",
                ListDubsDubbingStatusesVariant1Item.Preparing => "preparing",
                ListDubsDubbingStatusesVariant1Item.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDubsDubbingStatusesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "dubbed" => ListDubsDubbingStatusesVariant1Item.Dubbed,
                "dubbing" => ListDubsDubbingStatusesVariant1Item.Dubbing,
                "failed" => ListDubsDubbingStatusesVariant1Item.Failed,
                "preparing" => ListDubsDubbingStatusesVariant1Item.Preparing,
                "queued" => ListDubsDubbingStatusesVariant1Item.Queued,
                _ => null,
            };
        }
    }
}