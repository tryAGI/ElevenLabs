#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of auth connection config
    /// </summary>
    public readonly partial struct CreateAuthConnectionResponse : global::System.IEquatable<CreateAuthConnectionResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType? AuthType { get; }

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
        /// Response model for user-owned OAuth2 Custom App auth connections
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse? ApiIntegrationOauth2CustomApp { get; init; }
#else
        public global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse? ApiIntegrationOauth2CustomApp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiIntegrationOauth2CustomApp))]
#endif
        public bool IsApiIntegrationOauth2CustomApp => ApiIntegrationOauth2CustomApp != null;

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
        public static implicit operator CreateAuthConnectionResponse(global::ElevenLabs.OAuth2ClientCredsResponse value) => new CreateAuthConnectionResponse((global::ElevenLabs.OAuth2ClientCredsResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.OAuth2ClientCredsResponse?(CreateAuthConnectionResponse @this) => @this.Oauth2ClientCredentials;

        /// <summary>
        /// 
        /// </summary>
        public CreateAuthConnectionResponse(global::ElevenLabs.OAuth2ClientCredsResponse? value)
        {
            Oauth2ClientCredentials = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAuthConnectionResponse(global::ElevenLabs.BasicAuthResponse value) => new CreateAuthConnectionResponse((global::ElevenLabs.BasicAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BasicAuthResponse?(CreateAuthConnectionResponse @this) => @this.BasicAuth;

        /// <summary>
        /// 
        /// </summary>
        public CreateAuthConnectionResponse(global::ElevenLabs.BasicAuthResponse? value)
        {
            BasicAuth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAuthConnectionResponse(global::ElevenLabs.BearerAuthResponse value) => new CreateAuthConnectionResponse((global::ElevenLabs.BearerAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BearerAuthResponse?(CreateAuthConnectionResponse @this) => @this.BearerAuth;

        /// <summary>
        /// 
        /// </summary>
        public CreateAuthConnectionResponse(global::ElevenLabs.BearerAuthResponse? value)
        {
            BearerAuth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAuthConnectionResponse(global::ElevenLabs.OAuth2JWTResponse value) => new CreateAuthConnectionResponse((global::ElevenLabs.OAuth2JWTResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.OAuth2JWTResponse?(CreateAuthConnectionResponse @this) => @this.Oauth2Jwt;

        /// <summary>
        /// 
        /// </summary>
        public CreateAuthConnectionResponse(global::ElevenLabs.OAuth2JWTResponse? value)
        {
            Oauth2Jwt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAuthConnectionResponse(global::ElevenLabs.PrivateKeyJWTResponse value) => new CreateAuthConnectionResponse((global::ElevenLabs.PrivateKeyJWTResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PrivateKeyJWTResponse?(CreateAuthConnectionResponse @this) => @this.PrivateKeyJwt;

        /// <summary>
        /// 
        /// </summary>
        public CreateAuthConnectionResponse(global::ElevenLabs.PrivateKeyJWTResponse? value)
        {
            PrivateKeyJwt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAuthConnectionResponse(global::ElevenLabs.MTLSAuthResponse value) => new CreateAuthConnectionResponse((global::ElevenLabs.MTLSAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MTLSAuthResponse?(CreateAuthConnectionResponse @this) => @this.Mtls;

        /// <summary>
        /// 
        /// </summary>
        public CreateAuthConnectionResponse(global::ElevenLabs.MTLSAuthResponse? value)
        {
            Mtls = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAuthConnectionResponse(global::ElevenLabs.CustomHeaderAuthResponse value) => new CreateAuthConnectionResponse((global::ElevenLabs.CustomHeaderAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CustomHeaderAuthResponse?(CreateAuthConnectionResponse @this) => @this.CustomHeaderAuth;

        /// <summary>
        /// 
        /// </summary>
        public CreateAuthConnectionResponse(global::ElevenLabs.CustomHeaderAuthResponse? value)
        {
            CustomHeaderAuth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAuthConnectionResponse(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse value) => new CreateAuthConnectionResponse((global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse?(CreateAuthConnectionResponse @this) => @this.ApiIntegrationOauth2AuthCode;

        /// <summary>
        /// 
        /// </summary>
        public CreateAuthConnectionResponse(global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? value)
        {
            ApiIntegrationOauth2AuthCode = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAuthConnectionResponse(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse value) => new CreateAuthConnectionResponse((global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse?(CreateAuthConnectionResponse @this) => @this.ApiIntegrationOauth2CustomApp;

        /// <summary>
        /// 
        /// </summary>
        public CreateAuthConnectionResponse(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse? value)
        {
            ApiIntegrationOauth2CustomApp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateAuthConnectionResponse(global::ElevenLabs.WhatsAppAuthResponse value) => new CreateAuthConnectionResponse((global::ElevenLabs.WhatsAppAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WhatsAppAuthResponse?(CreateAuthConnectionResponse @this) => @this.WhatsappAuth;

        /// <summary>
        /// 
        /// </summary>
        public CreateAuthConnectionResponse(global::ElevenLabs.WhatsAppAuthResponse? value)
        {
            WhatsappAuth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateAuthConnectionResponse(
            global::ElevenLabs.CreateAuthConnectionResponseDiscriminatorAuthType? authType,
            global::ElevenLabs.OAuth2ClientCredsResponse? oauth2ClientCredentials,
            global::ElevenLabs.BasicAuthResponse? basicAuth,
            global::ElevenLabs.BearerAuthResponse? bearerAuth,
            global::ElevenLabs.OAuth2JWTResponse? oauth2Jwt,
            global::ElevenLabs.PrivateKeyJWTResponse? privateKeyJwt,
            global::ElevenLabs.MTLSAuthResponse? mtls,
            global::ElevenLabs.CustomHeaderAuthResponse? customHeaderAuth,
            global::ElevenLabs.ApiIntegrationOAuth2AuthCodeResponse? apiIntegrationOauth2AuthCode,
            global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse? apiIntegrationOauth2CustomApp,
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
            ApiIntegrationOauth2CustomApp = apiIntegrationOauth2CustomApp;
            WhatsappAuth = whatsappAuth;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WhatsappAuth as object ??
            ApiIntegrationOauth2CustomApp as object ??
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
            ApiIntegrationOauth2CustomApp?.ToString() ??
            WhatsappAuth?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsApiIntegrationOauth2CustomApp && !IsWhatsappAuth || !IsOauth2ClientCredentials && IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsApiIntegrationOauth2CustomApp && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsApiIntegrationOauth2CustomApp && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsApiIntegrationOauth2CustomApp && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsApiIntegrationOauth2CustomApp && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsApiIntegrationOauth2CustomApp && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsApiIntegrationOauth2CustomApp && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && IsApiIntegrationOauth2AuthCode && !IsApiIntegrationOauth2CustomApp && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && IsApiIntegrationOauth2CustomApp && !IsWhatsappAuth || !IsOauth2ClientCredentials && !IsBasicAuth && !IsBearerAuth && !IsOauth2Jwt && !IsPrivateKeyJwt && !IsMtls && !IsCustomHeaderAuth && !IsApiIntegrationOauth2AuthCode && !IsApiIntegrationOauth2CustomApp && IsWhatsappAuth;
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
            global::System.Func<global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse?, TResult>? apiIntegrationOauth2CustomApp = null,
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
            else if (IsApiIntegrationOauth2CustomApp && apiIntegrationOauth2CustomApp != null)
            {
                return apiIntegrationOauth2CustomApp(ApiIntegrationOauth2CustomApp!);
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
            global::System.Action<global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse?>? apiIntegrationOauth2CustomApp = null,
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
            else if (IsApiIntegrationOauth2CustomApp)
            {
                apiIntegrationOauth2CustomApp?.Invoke(ApiIntegrationOauth2CustomApp!);
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
                ApiIntegrationOauth2CustomApp,
                typeof(global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse),
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
        public bool Equals(CreateAuthConnectionResponse other)
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ApiIntegrationOAuth2CustomAppResponse?>.Default.Equals(ApiIntegrationOauth2CustomApp, other.ApiIntegrationOauth2CustomApp) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WhatsAppAuthResponse?>.Default.Equals(WhatsappAuth, other.WhatsappAuth) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateAuthConnectionResponse obj1, CreateAuthConnectionResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateAuthConnectionResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateAuthConnectionResponse obj1, CreateAuthConnectionResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateAuthConnectionResponse o && Equals(o);
        }
    }
}
