
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CampaignSource
    {
        /// <summary>
        ///
        /// </summary>
        Api,
        /// <summary>
        ///
        /// </summary>
        Ui,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignSource value)
        {
            return value switch
            {
                CampaignSource.Api => "api",
                CampaignSource.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignSource? ToEnum(string value)
        {
            return value switch
            {
                "api" => CampaignSource.Api,
                "ui" => CampaignSource.Ui,
                _ => null,
            };
        }
    }
}