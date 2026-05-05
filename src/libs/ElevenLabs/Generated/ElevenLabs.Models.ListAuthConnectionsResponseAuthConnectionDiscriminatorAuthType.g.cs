
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType
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
        WhatsappAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType value)
        {
            return value switch
            {
                ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.ApiIntegrationOauth2AuthCode => "api_integration_oauth2_auth_code",
                ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.ApiIntegrationOauth2CustomApp => "api_integration_oauth2_custom_app",
                ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.BasicAuth => "basic_auth",
                ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.BearerAuth => "bearer_auth",
                ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.CustomHeaderAuth => "custom_header_auth",
                ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.Mtls => "mtls",
                ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.Oauth2ClientCredentials => "oauth2_client_credentials",
                ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.Oauth2Jwt => "oauth2_jwt",
                ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.PrivateKeyJwt => "private_key_jwt",
                ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.WhatsappAuth => "whatsapp_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType? ToEnum(string value)
        {
            return value switch
            {
                "api_integration_oauth2_auth_code" => ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.ApiIntegrationOauth2AuthCode,
                "api_integration_oauth2_custom_app" => ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.ApiIntegrationOauth2CustomApp,
                "basic_auth" => ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.BasicAuth,
                "bearer_auth" => ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.BearerAuth,
                "custom_header_auth" => ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.CustomHeaderAuth,
                "mtls" => ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.Mtls,
                "oauth2_client_credentials" => ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.Oauth2ClientCredentials,
                "oauth2_jwt" => ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.Oauth2Jwt,
                "private_key_jwt" => ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.PrivateKeyJwt,
                "whatsapp_auth" => ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.WhatsappAuth,
                _ => null,
            };
        }
    }
}