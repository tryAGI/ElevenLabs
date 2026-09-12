
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: cloud_api
    /// </summary>
    public enum WhatsAppAccountType
    {
        /// <summary>
        ///
        /// </summary>
        CloudApi,
        /// <summary>
        ///
        /// </summary>
        Coexistence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhatsAppAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhatsAppAccountType value)
        {
            return value switch
            {
                WhatsAppAccountType.CloudApi => "cloud_api",
                WhatsAppAccountType.Coexistence => "coexistence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhatsAppAccountType? ToEnum(string value)
        {
            return value switch
            {
                "cloud_api" => WhatsAppAccountType.CloudApi,
                "coexistence" => WhatsAppAccountType.Coexistence,
                _ => null,
            };
        }
    }
}