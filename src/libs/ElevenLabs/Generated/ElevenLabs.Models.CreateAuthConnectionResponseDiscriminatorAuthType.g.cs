
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
        ApiIntegrationOauth2AuthCode,
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
        CustomHeaderAuth,
        /// <summary>
        /// 
        /// </summary>
        Mtls,
        /// <summary>
        /// 
        /// </summary>
        Oauth2ClientCredentials,
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
                CreateAuthConnectionResponseDiscriminatorAuthType.ApiIntegrationOauth2AuthCode => "api_integration_oauth2_auth_code",
                CreateAuthConnectionResponseDiscriminatorAuthType.BasicAuth => "basic_auth",
                CreateAuthConnectionResponseDiscriminatorAuthType.BearerAuth => "bearer_auth",
                CreateAuthConnectionResponseDiscriminatorAuthType.CustomHeaderAuth => "custom_header_auth",
                CreateAuthConnectionResponseDiscriminatorAuthType.Mtls => "mtls",
                CreateAuthConnectionResponseDiscriminatorAuthType.Oauth2ClientCredentials => "oauth2_client_credentials",
                CreateAuthConnectionResponseDiscriminatorAuthType.Oauth2Jwt => "oauth2_jwt",
                CreateAuthConnectionResponseDiscriminatorAuthType.PrivateKeyJwt => "private_key_jwt",
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
                "api_integration_oauth2_auth_code" => CreateAuthConnectionResponseDiscriminatorAuthType.ApiIntegrationOauth2AuthCode,
                "basic_auth" => CreateAuthConnectionResponseDiscriminatorAuthType.BasicAuth,
                "bearer_auth" => CreateAuthConnectionResponseDiscriminatorAuthType.BearerAuth,
                "custom_header_auth" => CreateAuthConnectionResponseDiscriminatorAuthType.CustomHeaderAuth,
                "mtls" => CreateAuthConnectionResponseDiscriminatorAuthType.Mtls,
                "oauth2_client_credentials" => CreateAuthConnectionResponseDiscriminatorAuthType.Oauth2ClientCredentials,
                "oauth2_jwt" => CreateAuthConnectionResponseDiscriminatorAuthType.Oauth2Jwt,
                "private_key_jwt" => CreateAuthConnectionResponseDiscriminatorAuthType.PrivateKeyJwt,
                "whatsapp_auth" => CreateAuthConnectionResponseDiscriminatorAuthType.WhatsappAuth,
                _ => null,
            };
        }
    }
}