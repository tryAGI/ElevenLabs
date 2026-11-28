
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum CampaignResponseChannelConfigDiscriminatorChannel
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
    public static class CampaignResponseChannelConfigDiscriminatorChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CampaignResponseChannelConfigDiscriminatorChannel value)
        {
            return value switch
            {
                CampaignResponseChannelConfigDiscriminatorChannel.Phone => "phone",
                CampaignResponseChannelConfigDiscriminatorChannel.Whatsapp => "whatsapp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CampaignResponseChannelConfigDiscriminatorChannel? ToEnum(string value)
        {
            return value switch
            {
                "phone" => CampaignResponseChannelConfigDiscriminatorChannel.Phone,
                "whatsapp" => CampaignResponseChannelConfigDiscriminatorChannel.Whatsapp,
                _ => null,
            };
        }
    }
}