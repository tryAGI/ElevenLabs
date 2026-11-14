
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ReceptionScrapingMode
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
    public static class ReceptionScrapingModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReceptionScrapingMode value)
        {
            return value switch
            {
                ReceptionScrapingMode.DeepScan => "deep_scan",
                ReceptionScrapingMode.QuickScan => "quick_scan",
                ReceptionScrapingMode.SinglePage => "single_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReceptionScrapingMode? ToEnum(string value)
        {
            return value switch
            {
                "deep_scan" => ReceptionScrapingMode.DeepScan,
                "quick_scan" => ReceptionScrapingMode.QuickScan,
                "single_page" => ReceptionScrapingMode.SinglePage,
                _ => null,
            };
        }
    }
}