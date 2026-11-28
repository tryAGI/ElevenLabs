
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum SubmitCampaignRequestChannelConfigDiscriminatorChannel
    {
        /// <summary>
        ///
        /// </summary>
        Phone,
        /// <summary>
        ///
        /// </summary>
        Whatsapp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubmitCampaignRequestChannelConfigDiscriminatorChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubmitCampaignRequestChannelConfigDiscriminatorChannel value)
        {
            return value switch
            {
                SubmitCampaignRequestChannelConfigDiscriminatorChannel.Phone => "phone",
                SubmitCampaignRequestChannelConfigDiscriminatorChannel.Whatsapp => "whatsapp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubmitCampaignRequestChannelConfigDiscriminatorChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone" => SubmitCampaignRequestChannelConfigDiscriminatorChannel.Phone,
                "whatsapp" => SubmitCampaignRequestChannelConfigDiscriminatorChannel.Whatsapp,
                _ => null,
            };
        }
    }
}