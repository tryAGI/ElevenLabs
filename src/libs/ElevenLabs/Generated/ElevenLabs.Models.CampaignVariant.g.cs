
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CampaignVariant
    {
        /// <summary>
        ///
        /// </summary>
        Advanced,
        /// <summary>
        ///
        /// </summary>
        Simple,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignVariantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignVariant value)
        {
            return value switch
            {
                CampaignVariant.Advanced => "advanced",
                CampaignVariant.Simple => "simple",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignVariant? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => CampaignVariant.Advanced,
                "simple" => CampaignVariant.Simple,
                _ => null,
            };
        }
    }
}