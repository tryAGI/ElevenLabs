
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SMBScrapingMode
    {
        /// <summary>
        ///
        /// </summary>
        DeepScan,
        /// <summary>
        ///
        /// </summary>
        QuickScan,
        /// <summary>
        ///
        /// </summary>
        SinglePage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SMBScrapingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SMBScrapingMode value)
        {
            return value switch
            {
                SMBScrapingMode.DeepScan => "deep_scan",
                SMBScrapingMode.QuickScan => "quick_scan",
                SMBScrapingMode.SinglePage => "single_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SMBScrapingMode? ToEnum(string value)
        {
            return value switch
            {
                "deep_scan" => SMBScrapingMode.DeepScan,
                "quick_scan" => SMBScrapingMode.QuickScan,
                "single_page" => SMBScrapingMode.SinglePage,
                _ => null,
            };
        }
    }
}