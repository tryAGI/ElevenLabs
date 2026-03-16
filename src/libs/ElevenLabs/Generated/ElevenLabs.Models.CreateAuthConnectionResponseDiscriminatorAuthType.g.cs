
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAuthConnectionResponseDiscriminatorAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        Oauth2ClientCredentials,
        /// <summary>
        /// 
        /// </summary>
        BasicAuth,
        /// <summary>
        /// 
        /// </summary>
        BearerAuth,
        /// <summary>
        /// 
        /// </summary>
        Oauth2Jwt,
        /// <summary>
        /// 
        /// </summary>
        PrivateKeyJwt,
        /// <summary>
        /// 
        /// </summary>
        CustomHeaderAuth,
        /// <summary>
        /// 
        /// </summary>
        ApiIntegrationOauth2AuthCode,
        /// <summary>
        /// 
        /// </summary>
        WhatsappAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAuthConnectionResponseDiscriminatorAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAuthConnectionResponseDiscriminatorAuthType value)
        {
            return value switch
            {
                CreateAuthConnectionResponseDiscriminatorAuthType.Oauth2ClientCredentials => "oauth2_client_credentials",
                CreateAuthConnectionResponseDiscriminatorAuthType.BasicAuth => "basic_auth",
                CreateAuthConnectionResponseDiscriminatorAuthType.BearerAuth => "bearer_auth",
                CreateAuthConnectionResponseDiscriminatorAuthType.Oauth2Jwt => "oauth2_jwt",
                CreateAuthConnectionResponseDiscriminatorAuthType.PrivateKeyJwt => "private_key_jwt",
                CreateAuthConnectionResponseDiscriminatorAuthType.CustomHeaderAuth => "custom_header_auth",
                CreateAuthConnectionResponseDiscriminatorAuthType.ApiIntegrationOauth2AuthCode => "api_integration_oauth2_auth_code",
                CreateAuthConnectionResponseDiscriminatorAuthType.WhatsappAuth => "whatsapp_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAuthConnectionResponseDiscriminatorAuthType? ToEnum(string value)
        {
            return value switch
            {
                "oauth2_client_credentials" => CreateAuthConnectionResponseDiscriminatorAuthType.Oauth2ClientCredentials,
                "basic_auth" => CreateAuthConnectionResponseDiscriminatorAuthType.BasicAuth,
                "bearer_auth" => CreateAuthConnectionResponseDiscriminatorAuthType.BearerAuth,
                "oauth2_jwt" => CreateAuthConnectionResponseDiscriminatorAuthType.Oauth2Jwt,
                "private_key_jwt" => CreateAuthConnectionResponseDiscriminatorAuthType.PrivateKeyJwt,
                "custom_header_auth" => CreateAuthConnectionResponseDiscriminatorAuthType.CustomHeaderAuth,
                "api_integration_oauth2_auth_code" => CreateAuthConnectionResponseDiscriminatorAuthType.ApiIntegrationOauth2AuthCode,
                "whatsapp_auth" => CreateAuthConnectionResponseDiscriminatorAuthType.WhatsappAuth,
                _ => null,
            };
        }
    }
}