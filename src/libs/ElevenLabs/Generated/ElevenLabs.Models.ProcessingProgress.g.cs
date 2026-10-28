
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Single-word processing step shown in the UI status badge.
    /// </summary>
    public enum ProcessingProgress
    {
        /// <summary>
        ///
        /// </summary>
        Converting,
        /// <summary>
        ///
        /// </summary>
        Crawling,
        /// <summary>
        ///
        /// </summary>
        Extracting,
        /// <summary>
        ///
        /// </summary>
        Scraping,
        /// <summary>
        ///
        /// </summary>
        Storing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProcessingProgressExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProcessingProgress value)
        {
            return value switch
            {
                ProcessingProgress.Converting => "Converting",
                ProcessingProgress.Crawling => "Crawling",
                ProcessingProgress.Extracting => "Extracting",
                ProcessingProgress.Scraping => "Scraping",
                ProcessingProgress.Storing => "Storing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProcessingProgress? ToEnum(string value)
        {
            return value switch
            {
                "Converting" => ProcessingProgress.Converting,
                "Crawling" => ProcessingProgress.Crawling,
                "Extracting" => ProcessingProgress.Extracting,
                "Scraping" => ProcessingProgress.Scraping,
                "Storing" => ProcessingProgress.Storing,
                _ => null,
            };
        }
    }
}