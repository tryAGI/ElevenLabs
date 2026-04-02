#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class AuthConnectionsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.AuthConnectionsItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.AuthConnectionsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.OAuth2ClientCredsResponse? oauth2ClientCredentials = default;
            if (discriminator?.AuthType == global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.Oauth2ClientCredentials)
            {
                oauth2ClientCredentials = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.OAuth2ClientCredsResponse>(ref reader, options);
            }
            global::ElevenLabs.BasicAuthResponse? basicAuth = default;
            if (discriminator?.AuthType == global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.BasicAuth)
            {
                basicAuth = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.BasicAuthResponse>(ref reader, options);
            }
            global::ElevenLabs.BearerAuthResponse? bearerAuth = default;
            if (discriminator?.AuthType == global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.BearerAuth)
            {
                bearerAuth = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.BearerAuthResponse>(ref reader, options);
            }
            global::ElevenLabs.OAuth2JWTResponse? oauth2Jwt = default;
            if (discriminator?.AuthType == global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.Oauth2Jwt)
            {
                oauth2Jwt = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.OAuth2JWTResponse>(ref reader, options);
            }
            global::ElevenLabs.PrivateKeyJWTResponse? privateKeyJwt = default;
            if (discriminator?.AuthType == global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.PrivateKeyJwt)
            {
                privateKeyJwt = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PrivateKeyJWTResponse>(ref reader, options);
            }
            global::ElevenLabs.MTLSAuthResponse? mtls = default;
            if (discriminator?.AuthType == global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.Mtls)
            {
                mtls = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.MTLSAuthResponse>(ref reader, options);
            }
            global::ElevenLabs.CustomHeaderAuthResponse? customHeaderAuth = default;
            if (discriminator?.AuthType == global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.CustomHeaderAuth)
            {
                customHeaderAuth = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.CustomHeaderAuthResponse>(ref reader, options);
            }
            global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? apiIntegrationOauth2AuthCode = default;
            if (discriminator?.AuthType == global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.ApiIntegrationOauth2AuthCode)
            {
                apiIntegrationOauth2AuthCode = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse>(ref reader, options);
            }
            global::ElevenLabs.WhatsAppAuthResponse? whatsappAuth = default;
            if (discriminator?.AuthType == global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType.WhatsappAuth)
            {
                whatsappAuth = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.WhatsAppAuthResponse>(ref reader, options);
            }

            var __value = new global::ElevenLabs.AuthConnectionsItem(
                discriminator?.AuthType,
                oauth2ClientCredentials,

                basicAuth,

                bearerAuth,

                oauth2Jwt,

                privateKeyJwt,

                mtls,

                customHeaderAuth,

                apiIntegrationOauth2AuthCode,

                whatsappAuth
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.AuthConnectionsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOauth2ClientCredentials)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2ClientCredentials, typeof(global::ElevenLabs.OAuth2ClientCredsResponse), options);
            }
            else if (value.IsBasicAuth)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasicAuth, typeof(global::ElevenLabs.BasicAuthResponse), options);
            }
            else if (value.IsBearerAuth)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BearerAuth, typeof(global::ElevenLabs.BearerAuthResponse), options);
            }
            else if (value.IsOauth2Jwt)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2Jwt, typeof(global::ElevenLabs.OAuth2JWTResponse), options);
            }
            else if (value.IsPrivateKeyJwt)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PrivateKeyJwt, typeof(global::ElevenLabs.PrivateKeyJWTResponse), options);
            }
            else if (value.IsMtls)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mtls, typeof(global::ElevenLabs.MTLSAuthResponse), options);
            }
            else if (value.IsCustomHeaderAuth)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomHeaderAuth, typeof(global::ElevenLabs.CustomHeaderAuthResponse), options);
            }
            else if (value.IsApiIntegrationOauth2AuthCode)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiIntegrationOauth2AuthCode, typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse), options);
            }
            else if (value.IsWhatsappAuth)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WhatsappAuth, typeof(global::ElevenLabs.WhatsAppAuthResponse), options);
            }
        }
    }
}