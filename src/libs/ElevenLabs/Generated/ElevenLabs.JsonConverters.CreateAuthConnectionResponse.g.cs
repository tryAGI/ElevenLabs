#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class CreateAuthConnectionResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.CreateAuthConnectionResponse>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.CreateAuthConnectionResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CreateAuthConnectionResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CreateAuthConnectionResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.OAuth2ClientCredsResponse? oauth2ClientCredentials = default;
            if (discriminator?.AuthType == global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType.Oauth2ClientCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OAuth2ClientCredsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OAuth2ClientCredsResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.OAuth2ClientCredsResponse)}");
                oauth2ClientCredentials = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BasicAuthResponse? basicAuth = default;
            if (discriminator?.AuthType == global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType.BasicAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BasicAuthResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BasicAuthResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BasicAuthResponse)}");
                basicAuth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BearerAuthResponse? bearerAuth = default;
            if (discriminator?.AuthType == global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType.BearerAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BearerAuthResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BearerAuthResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BearerAuthResponse)}");
                bearerAuth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.OAuth2JWTResponse? oauth2Jwt = default;
            if (discriminator?.AuthType == global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType.Oauth2Jwt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OAuth2JWTResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OAuth2JWTResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.OAuth2JWTResponse)}");
                oauth2Jwt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.PrivateKeyJWTResponse? privateKeyJwt = default;
            if (discriminator?.AuthType == global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType.PrivateKeyJwt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PrivateKeyJWTResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PrivateKeyJWTResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PrivateKeyJWTResponse)}");
                privateKeyJwt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.MTLSAuthResponse? mtls = default;
            if (discriminator?.AuthType == global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType.Mtls)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MTLSAuthResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MTLSAuthResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.MTLSAuthResponse)}");
                mtls = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.CustomHeaderAuthResponse? customHeaderAuth = default;
            if (discriminator?.AuthType == global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType.CustomHeaderAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CustomHeaderAuthResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CustomHeaderAuthResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.CustomHeaderAuthResponse)}");
                customHeaderAuth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? apiIntegrationOauth2AuthCode = default;
            if (discriminator?.AuthType == global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType.ApiIntegrationOauth2AuthCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse)}");
                apiIntegrationOauth2AuthCode = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WhatsAppAuthResponse? whatsappAuth = default;
            if (discriminator?.AuthType == global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType.WhatsappAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WhatsAppAuthResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WhatsAppAuthResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WhatsAppAuthResponse)}");
                whatsappAuth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.CreateAuthConnectionResponse(
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
            global::ElevenLabs.CreateAuthConnectionResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOauth2ClientCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OAuth2ClientCredsResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OAuth2ClientCredsResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.OAuth2ClientCredsResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2ClientCredentials, typeInfo);
            }
            else if (value.IsBasicAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BasicAuthResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BasicAuthResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BasicAuthResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BasicAuth, typeInfo);
            }
            else if (value.IsBearerAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BearerAuthResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BearerAuthResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BearerAuthResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BearerAuth, typeInfo);
            }
            else if (value.IsOauth2Jwt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.OAuth2JWTResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.OAuth2JWTResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.OAuth2JWTResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2Jwt, typeInfo);
            }
            else if (value.IsPrivateKeyJwt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PrivateKeyJWTResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PrivateKeyJWTResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PrivateKeyJWTResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PrivateKeyJwt, typeInfo);
            }
            else if (value.IsMtls)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.MTLSAuthResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.MTLSAuthResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.MTLSAuthResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Mtls, typeInfo);
            }
            else if (value.IsCustomHeaderAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.CustomHeaderAuthResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.CustomHeaderAuthResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.CustomHeaderAuthResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CustomHeaderAuth, typeInfo);
            }
            else if (value.IsApiIntegrationOauth2AuthCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiIntegrationOauth2AuthCode, typeInfo);
            }
            else if (value.IsWhatsappAuth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WhatsAppAuthResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WhatsAppAuthResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WhatsAppAuthResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WhatsappAuth, typeInfo);
            }
        }
    }
}