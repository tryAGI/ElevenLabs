
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum SsoProviderResponseModelProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Saml,
        /// <summary>
        /// 
        /// </summary>
        Oidc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SsoProviderResponseModelProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SsoProviderResponseModelProviderType value)
        {
            return value switch
            {
                SsoProviderResponseModelProviderType.Saml => "saml",
                SsoProviderResponseModelProviderType.Oidc => "oidc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SsoProviderResponseModelProviderType? ToEnum(string value)
        {
            return value switch
            {
                "saml" => SsoProviderResponseModelProviderType.Saml,
                "oidc" => SsoProviderResponseModelProviderType.Oidc,
                _ => null,
            };
        }
    }
}