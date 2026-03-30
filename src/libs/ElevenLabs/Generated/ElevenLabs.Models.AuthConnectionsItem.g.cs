#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of auth connection config
    /// </summary>
    public readonly partial struct AuthConnectionsItem : global::System.IEquatable<AuthConnectionsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType? AuthType { get; }

        /// <summary>
        /// Response model for oauth2 client creds
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.OAuth2ClientCredsResponse? Oauth2ClientCredentials { get; init; }
#else
        public global::ElevenLabs.OAuth2ClientCredsResponse? Oauth2ClientCredentials { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oauth2ClientCredentials))]
#endif
        public bool IsOauth2ClientCredentials => Oauth2ClientCredentials != null;

        /// <summary>
        /// Response model for basic auth
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BasicAuthResponse? BasicAuth { get; init; }
#else
        public global::ElevenLabs.BasicAuthResponse? BasicAuth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BasicAuth))]
#endif
        public bool IsBasicAuth => BasicAuth != null;

        /// <summary>
        /// Response model for bearer auth
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BearerAuthResponse? BearerAuth { get; init; }
#else
        public global::ElevenLabs.BearerAuthResponse? BearerAuth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BearerAuth))]
#endif
        public bool IsBearerAuth => BearerAuth != null;

        /// <summary>
        /// Response model for OAuth2 JWT auth connections
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.OAuth2JWTResponse? Oauth2Jwt { get; init; }
#else
        public global::ElevenLabs.OAuth2JWTResponse? Oauth2Jwt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oauth2Jwt))]
#endif
        public bool IsOauth2Jwt => Oauth2Jwt != null;

        /// <summary>
        /// Response model for Private Key JWT auth connections
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PrivateKeyJWTResponse? PrivateKeyJwt { get; init; }
#else
        public global::ElevenLabs.PrivateKeyJWTResponse? PrivateKeyJwt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PrivateKeyJwt))]
#endif
        public bool IsPrivateKeyJwt => PrivateKeyJwt != null;

        /// <summary>
        /// Response model for mTLS auth connections.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MTLSAuthResponse? Mtls { get; init; }
#else
        public global::ElevenLabs.MTLSAuthResponse? Mtls { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mtls))]
#endif
        public bool IsMtls => Mtls != null;

        /// <summary>
        /// Response model for Custom Header Auth auth connections
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CustomHeaderAuthResponse? CustomHeaderAuth { get; init; }
#else
        public global::ElevenLabs.CustomHeaderAuthResponse? CustomHeaderAuth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CustomHeaderAuth))]
#endif
        public bool IsCustomHeaderAuth => CustomHeaderAuth != null;

        /// <summary>
        /// Response model for integration-managed OAuth2 Auth Code auth connections
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? ApiIntegrationOauth2AuthCode { get; init; }
#else
        public global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? ApiIntegrationOauth2AuthCode { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiIntegrationOauth2AuthCode))]
#endif
        public bool IsApiIntegrationOauth2AuthCode => ApiIntegrationOauth2AuthCode != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WhatsAppAuthResponse? WhatsappAuth { get; init; }
#else
        public global::ElevenLabs.WhatsAppAuthResponse? WhatsappAuth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WhatsappAuth))]
#endif
        public bool IsWhatsappAuth => WhatsappAuth != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConnectionsItem(global::ElevenLabs.OAuth2ClientCredsResponse value) => new AuthConnectionsItem((global::ElevenLabs.OAuth2ClientCredsResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.OAuth2ClientCredsResponse?(AuthConnectionsItem @this) => @this.Oauth2ClientCredentials;

        /// <summary>
        /// 
        /// </summary>
        public AuthConnectionsItem(global::ElevenLabs.OAuth2ClientCredsResponse? value)
        {
            Oauth2ClientCredentials = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConnectionsItem(global::ElevenLabs.BasicAuthResponse value) => new AuthConnectionsItem((global::ElevenLabs.BasicAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BasicAuthResponse?(AuthConnectionsItem @this) => @this.BasicAuth;

        /// <summary>
        /// 
        /// </summary>
        public AuthConnectionsItem(global::ElevenLabs.BasicAuthResponse? value)
        {
            BasicAuth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConnectionsItem(global::ElevenLabs.BearerAuthResponse value) => new AuthConnectionsItem((global::ElevenLabs.BearerAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BearerAuthResponse?(AuthConnectionsItem @this) => @this.BearerAuth;

        /// <summary>
        /// 
        /// </summary>
        public AuthConnectionsItem(global::ElevenLabs.BearerAuthResponse? value)
        {
            BearerAuth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConnectionsItem(global::ElevenLabs.OAuth2JWTResponse value) => new AuthConnectionsItem((global::ElevenLabs.OAuth2JWTResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.OAuth2JWTResponse?(AuthConnectionsItem @this) => @this.Oauth2Jwt;

        /// <summary>
        /// 
        /// </summary>
        public AuthConnectionsItem(global::ElevenLabs.OAuth2JWTResponse? value)
        {
            Oauth2Jwt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConnectionsItem(global::ElevenLabs.PrivateKeyJWTResponse value) => new AuthConnectionsItem((global::ElevenLabs.PrivateKeyJWTResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PrivateKeyJWTResponse?(AuthConnectionsItem @this) => @this.PrivateKeyJwt;

        /// <summary>
        /// 
        /// </summary>
        public AuthConnectionsItem(global::ElevenLabs.PrivateKeyJWTResponse? value)
        {
            PrivateKeyJwt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConnectionsItem(global::ElevenLabs.MTLSAuthResponse value) => new AuthConnectionsItem((global::ElevenLabs.MTLSAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MTLSAuthResponse?(AuthConnectionsItem @this) => @this.Mtls;

        /// <summary>
        /// 
        /// </summary>
        public AuthConnectionsItem(global::ElevenLabs.MTLSAuthResponse? value)
        {
            Mtls = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConnectionsItem(global::ElevenLabs.CustomHeaderAuthResponse value) => new AuthConnectionsItem((global::ElevenLabs.CustomHeaderAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CustomHeaderAuthResponse?(AuthConnectionsItem @this) => @this.CustomHeaderAuth;

        /// <summary>
        /// 
        /// </summary>
        public AuthConnectionsItem(global::ElevenLabs.CustomHeaderAuthResponse? value)
        {
            CustomHeaderAuth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConnectionsItem(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse value) => new AuthConnectionsItem((global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse?(AuthConnectionsItem @this) => @this.ApiIntegrationOauth2AuthCode;

        /// <summary>
        /// 
        /// </summary>
        public AuthConnectionsItem(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? value)
        {
            ApiIntegrationOauth2AuthCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AuthConnectionsItem(global::ElevenLabs.WhatsAppAuthResponse value) => new AuthConnectionsItem((global::ElevenLabs.WhatsAppAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WhatsAppAuthResponse?(AuthConnectionsItem @this) => @this.WhatsappAuth;

        /// <summary>
        /// 
        /// </summary>
        public AuthConnectionsItem(global::ElevenLabs.WhatsAppAuthResponse? value)
        {
            WhatsappAuth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AuthConnectionsItem(
            global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType? authType,
            global::ElevenLabs.OAuth2ClientCredsResponse? oauth2ClientCredentials,
            global::ElevenLabs.BasicAuthResponse? basicAuth,
            global::ElevenLabs.BearerAuthResponse? bearerAuth,
            global::ElevenLabs.OAuth2JWTResponse? oauth2Jwt,
            global::ElevenLabs.PrivateKeyJWTResponse? privateKeyJwt,
            global::ElevenLabs.MTLSAuthResponse? mtls,
            global::ElevenLabs.CustomHeaderAuthResponse? customHeaderAuth,
            global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? apiIntegrationOauth2AuthCode,
            global::ElevenLabs.WhatsAppAuthResponse? whatsappAuth
            )
        {
            AuthType = authType;

            Oauth2ClientCredentials = oauth2ClientCredentials;
            BasicAuth = basicAuth;
            BearerAuth = bearerAuth;
            Oauth2Jwt = oauth2Jwt;
            PrivateKeyJwt = privateKeyJwt;
            Mtls = mtls;
            CustomHeaderAuth = customHeaderAuth;
            ApiIntegrationOauth2AuthCode = apiIntegrationOauth2AuthCode;
            WhatsappAuth = whatsappAuth;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WhatsappAuth as object ??
            ApiIntegrationOauth2AuthCode as object ??
            CustomHeaderAuth as object ??
            Mtls as object ??
            PrivateKeyJwt as object ??
            Oauth2Jwt as object ??
            BearerAuth as object ??
            BasicAuth as object ??
            Oauth2ClientCredentials as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Oauth2ClientCredentials?.ToString() ??
            BasicAuth?.ToString() ??
            BearerAuth?.ToString() ??
            Oauth2Jwt?.ToString() ??
            PrivateKeyJwt?.ToString() ??
            Mtls?.ToString() ??
            CustomHeaderAuth?.ToString() ??
            ApiIntegrationOauth2AuthCode?.ToString() ??
            WhatsappAuth?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsWhatsappAuth || !IsOauth2ClientCredentials && IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && IsApiIntegrationOauth2AuthCode && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && IsWhatsappAuth;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.OAuth2ClientCredsResponse?, TResult>? oauth2ClientCredentials = null,
            global::System.Func<global::ElevenLabs.BasicAuthResponse?, TResult>? basicAuth = null,
            global::System.Func<global::ElevenLabs.BearerAuthResponse?, TResult>? bearerAuth = null,
            global::System.Func<global::ElevenLabs.OAuth2JWTResponse?, TResult>? oauth2Jwt = null,
            global::System.Func<global::ElevenLabs.PrivateKeyJWTResponse?, TResult>? privateKeyJwt = null,
            global::System.Func<global::ElevenLabs.MTLSAuthResponse?, TResult>? mtls = null,
            global::System.Func<global::ElevenLabs.CustomHeaderAuthResponse?, TResult>? customHeaderAuth = null,
            global::System.Func<global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse?, TResult>? apiIntegrationOauth2AuthCode = null,
            global::System.Func<global::ElevenLabs.WhatsAppAuthResponse?, TResult>? whatsappAuth = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOauth2ClientCredentials && oauth2ClientCredentials != null)
            {
                return oauth2ClientCredentials(Oauth2ClientCredentials!);
            }
            else if (IsBasicAuth && basicAuth != null)
            {
                return basicAuth(BasicAuth!);
            }
            else if (IsBearerAuth && bearerAuth != null)
            {
                return bearerAuth(BearerAuth!);
            }
            else if (IsOauth2Jwt && oauth2Jwt != null)
            {
                return oauth2Jwt(Oauth2Jwt!);
            }
            else if (IsPrivateKeyJwt && privateKeyJwt != null)
            {
                return privateKeyJwt(PrivateKeyJwt!);
            }
            else if (IsMtls && mtls != null)
            {
                return mtls(Mtls!);
            }
            else if (IsCustomHeaderAuth && customHeaderAuth != null)
            {
                return customHeaderAuth(CustomHeaderAuth!);
            }
            else if (IsApiIntegrationOauth2AuthCode && apiIntegrationOauth2AuthCode != null)
            {
                return apiIntegrationOauth2AuthCode(ApiIntegrationOauth2AuthCode!);
            }
            else if (IsWhatsappAuth && whatsappAuth != null)
            {
                return whatsappAuth(WhatsappAuth!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.OAuth2ClientCredsResponse?>? oauth2ClientCredentials = null,
            global::System.Action<global::ElevenLabs.BasicAuthResponse?>? basicAuth = null,
            global::System.Action<global::ElevenLabs.BearerAuthResponse?>? bearerAuth = null,
            global::System.Action<global::ElevenLabs.OAuth2JWTResponse?>? oauth2Jwt = null,
            global::System.Action<global::ElevenLabs.PrivateKeyJWTResponse?>? privateKeyJwt = null,
            global::System.Action<global::ElevenLabs.MTLSAuthResponse?>? mtls = null,
            global::System.Action<global::ElevenLabs.CustomHeaderAuthResponse?>? customHeaderAuth = null,
            global::System.Action<global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse?>? apiIntegrationOauth2AuthCode = null,
            global::System.Action<global::ElevenLabs.WhatsAppAuthResponse?>? whatsappAuth = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOauth2ClientCredentials)
            {
                oauth2ClientCredentials?.Invoke(Oauth2ClientCredentials!);
            }
            else if (IsBasicAuth)
            {
                basicAuth?.Invoke(BasicAuth!);
            }
            else if (IsBearerAuth)
            {
                bearerAuth?.Invoke(BearerAuth!);
            }
            else if (IsOauth2Jwt)
            {
                oauth2Jwt?.Invoke(Oauth2Jwt!);
            }
            else if (IsPrivateKeyJwt)
            {
                privateKeyJwt?.Invoke(PrivateKeyJwt!);
            }
            else if (IsMtls)
            {
                mtls?.Invoke(Mtls!);
            }
            else if (IsCustomHeaderAuth)
            {
                customHeaderAuth?.Invoke(CustomHeaderAuth!);
            }
            else if (IsApiIntegrationOauth2AuthCode)
            {
                apiIntegrationOauth2AuthCode?.Invoke(ApiIntegrationOauth2AuthCode!);
            }
            else if (IsWhatsappAuth)
            {
                whatsappAuth?.Invoke(WhatsappAuth!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Oauth2ClientCredentials,
                typeof(global::ElevenLabs.OAuth2ClientCredsResponse),
                BasicAuth,
                typeof(global::ElevenLabs.BasicAuthResponse),
                BearerAuth,
                typeof(global::ElevenLabs.BearerAuthResponse),
                Oauth2Jwt,
                typeof(global::ElevenLabs.OAuth2JWTResponse),
                PrivateKeyJwt,
                typeof(global::ElevenLabs.PrivateKeyJWTResponse),
                Mtls,
                typeof(global::ElevenLabs.MTLSAuthResponse),
                CustomHeaderAuth,
                typeof(global::ElevenLabs.CustomHeaderAuthResponse),
                ApiIntegrationOauth2AuthCode,
                typeof(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse),
                WhatsappAuth,
                typeof(global::ElevenLabs.WhatsAppAuthResponse),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(AuthConnectionsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.OAuth2ClientCredsResponse?>.Default.Equals(Oauth2ClientCredentials, other.Oauth2ClientCredentials) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BasicAuthResponse?>.Default.Equals(BasicAuth, other.BasicAuth) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BearerAuthResponse?>.Default.Equals(BearerAuth, other.BearerAuth) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.OAuth2JWTResponse?>.Default.Equals(Oauth2Jwt, other.Oauth2Jwt) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PrivateKeyJWTResponse?>.Default.Equals(PrivateKeyJwt, other.PrivateKeyJwt) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MTLSAuthResponse?>.Default.Equals(Mtls, other.Mtls) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CustomHeaderAuthResponse?>.Default.Equals(CustomHeaderAuth, other.CustomHeaderAuth) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse?>.Default.Equals(ApiIntegrationOauth2AuthCode, other.ApiIntegrationOauth2AuthCode) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WhatsAppAuthResponse?>.Default.Equals(WhatsappAuth, other.WhatsappAuth) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AuthConnectionsItem obj1, AuthConnectionsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AuthConnectionsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AuthConnectionsItem obj1, AuthConnectionsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AuthConnectionsItem o && Equals(o);
        }
    }
}
