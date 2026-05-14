
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAuthConnectionResponseDiscriminatorAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiIntegrationOauth2AuthCode,
        /// <summary>
        /// 
        /// </summary>
        ApiIntegrationOauth2CustomApp,
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
        SlackBotAuth,
        /// <summary>
        /// 
        /// </summary>
        WhatsappAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAuthConnectionResponseDiscriminatorAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAuthConnectionResponseDiscriminatorAuthType value)
        {
            return value switch
            {
                UpdateAuthConnectionResponseDiscriminatorAuthType.ApiIntegrationOauth2AuthCode => "api_integration_oauth2_auth_code",
                UpdateAuthConnectionResponseDiscriminatorAuthType.ApiIntegrationOauth2CustomApp => "api_integration_oauth2_custom_app",
                UpdateAuthConnectionResponseDiscriminatorAuthType.BasicAuth => "basic_auth",
                UpdateAuthConnectionResponseDiscriminatorAuthType.BearerAuth => "bearer_auth",
                UpdateAuthConnectionResponseDiscriminatorAuthType.CustomHeaderAuth => "custom_header_auth",
                UpdateAuthConnectionResponseDiscriminatorAuthType.Mtls => "mtls",
                UpdateAuthConnectionResponseDiscriminatorAuthType.Oauth2ClientCredentials => "oauth2_client_credentials",
                UpdateAuthConnectionResponseDiscriminatorAuthType.Oauth2Jwt => "oauth2_jwt",
                UpdateAuthConnectionResponseDiscriminatorAuthType.PrivateKeyJwt => "private_key_jwt",
                UpdateAuthConnectionResponseDiscriminatorAuthType.SlackBotAuth => "slack_bot_auth",
                UpdateAuthConnectionResponseDiscriminatorAuthType.WhatsappAuth => "whatsapp_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAuthConnectionResponseDiscriminatorAuthType? ToEnum(string value)
        {
            return value switch
            {
                "api_integration_oauth2_auth_code" => UpdateAuthConnectionResponseDiscriminatorAuthType.ApiIntegrationOauth2AuthCode,
                "api_integration_oauth2_custom_app" => UpdateAuthConnectionResponseDiscriminatorAuthType.ApiIntegrationOauth2CustomApp,
                "basic_auth" => UpdateAuthConnectionResponseDiscriminatorAuthType.BasicAuth,
                "bearer_auth" => UpdateAuthConnectionResponseDiscriminatorAuthType.BearerAuth,
                "custom_header_auth" => UpdateAuthConnectionResponseDiscriminatorAuthType.CustomHeaderAuth,
                "mtls" => UpdateAuthConnectionResponseDiscriminatorAuthType.Mtls,
                "oauth2_client_credentials" => UpdateAuthConnectionResponseDiscriminatorAuthType.Oauth2ClientCredentials,
                "oauth2_jwt" => UpdateAuthConnectionResponseDiscriminatorAuthType.Oauth2Jwt,
                "private_key_jwt" => UpdateAuthConnectionResponseDiscriminatorAuthType.PrivateKeyJwt,
                "slack_bot_auth" => UpdateAuthConnectionResponseDiscriminatorAuthType.SlackBotAuth,
                "whatsapp_auth" => UpdateAuthConnectionResponseDiscriminatorAuthType.WhatsappAuth,
                _ => null,
            };
        }
    }
}