
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ListCampaignsMode
    {
        /// <summary>
        ///
        /// </summary>
        Message,
        /// <summary>
        ///
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCampaignsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCampaignsMode value)
        {
            return value switch
            {
                ListCampaignsMode.Message => "message",
                ListCampaignsMode.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCampaignsMode? ToEnum(string value)
        {
            return value switch
            {
                "message" => ListCampaignsMode.Message,
                "voice" => ListCampaignsMode.Voice,
                _ => null,
            };
        }
    }
}