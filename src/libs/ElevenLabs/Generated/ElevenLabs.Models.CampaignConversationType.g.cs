
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CampaignConversationType
    {
        /// <summary>
        ///
        /// </summary>
        Callback,
        /// <summary>
        ///
        /// </summary>
        Initial,
        /// <summary>
        ///
        /// </summary>
        Redirect,
        /// <summary>
        ///
        /// </summary>
        Retry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CampaignConversationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignConversationType value)
        {
            return value switch
            {
                CampaignConversationType.Callback => "callback",
                CampaignConversationType.Initial => "initial",
                CampaignConversationType.Redirect => "redirect",
                CampaignConversationType.Retry => "retry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignConversationType? ToEnum(string value)
        {
            return value switch
            {
                "callback" => CampaignConversationType.Callback,
                "initial" => CampaignConversationType.Initial,
                "redirect" => CampaignConversationType.Redirect,
                "retry" => CampaignConversationType.Retry,
                _ => null,
            };
        }
    }
}