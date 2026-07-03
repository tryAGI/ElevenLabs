
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: queued
    /// </summary>
    public enum CrawlStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CrawlStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CrawlStatus value)
        {
            return value switch
            {
                CrawlStatus.Cancelled => "cancelled",
                CrawlStatus.Failed => "failed",
                CrawlStatus.Processing => "processing",
                CrawlStatus.Queued => "queued",
                CrawlStatus.Skipped => "skipped",
                CrawlStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CrawlStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => CrawlStatus.Cancelled,
                "failed" => CrawlStatus.Failed,
                "processing" => CrawlStatus.Processing,
                "queued" => CrawlStatus.Queued,
                "skipped" => CrawlStatus.Skipped,
                "succeeded" => CrawlStatus.Succeeded,
                _ => null,
            };
        }
    }
}