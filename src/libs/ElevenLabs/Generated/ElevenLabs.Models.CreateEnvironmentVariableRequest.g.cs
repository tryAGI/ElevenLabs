#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateEnvironmentVariableRequest : global::System.IEquatable<CreateEnvironmentVariableRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateStringEnvironmentVariableRequest? String { get; init; }
#else
        public global::ElevenLabs.CreateStringEnvironmentVariableRequest? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateSecretEnvironmentVariableRequest? Secret { get; init; }
#else
        public global::ElevenLabs.CreateSecretEnvironmentVariableRequest? Secret { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Secret))]
#endif
        public bool IsSecret => Secret != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest? AuthConnection { get; init; }
#else
        public global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest? AuthConnection { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AuthConnection))]
#endif
        public bool IsAuthConnection => AuthConnection != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateEnvironmentVariableRequest(global::ElevenLabs.CreateStringEnvironmentVariableRequest value) => new CreateEnvironmentVariableRequest((global::ElevenLabs.CreateStringEnvironmentVariableRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateStringEnvironmentVariableRequest?(CreateEnvironmentVariableRequest @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public CreateEnvironmentVariableRequest(global::ElevenLabs.CreateStringEnvironmentVariableRequest? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateEnvironmentVariableRequest(global::ElevenLabs.CreateSecretEnvironmentVariableRequest value) => new CreateEnvironmentVariableRequest((global::ElevenLabs.CreateSecretEnvironmentVariableRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateSecretEnvironmentVariableRequest?(CreateEnvironmentVariableRequest @this) => @this.Secret;

        /// <summary>
        /// 
        /// </summary>
        public CreateEnvironmentVariableRequest(global::ElevenLabs.CreateSecretEnvironmentVariableRequest? value)
        {
            Secret = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateEnvironmentVariableRequest(global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest value) => new CreateEnvironmentVariableRequest((global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest?(CreateEnvironmentVariableRequest @this) => @this.AuthConnection;

        /// <summary>
        /// 
        /// </summary>
        public CreateEnvironmentVariableRequest(global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest? value)
        {
            AuthConnection = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreateEnvironmentVariableRequest(
            global::ElevenLabs.CreateEnvironmentVariableRequestDiscriminatorType? type,
            global::ElevenLabs.CreateStringEnvironmentVariableRequest? @string,
            global::ElevenLabs.CreateSecretEnvironmentVariableRequest? secret,
            global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest? authConnection
            )
        {
            Type = type;

            String = @string;
            Secret = secret;
            AuthConnection = authConnection;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AuthConnection as object ??
            Secret as object ??
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            Secret?.ToString() ??
            AuthConnection?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsSecret && !IsAuthConnection || !IsString && IsSecret && !IsAuthConnection || !IsString && !IsSecret && IsAuthConnection;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.CreateStringEnvironmentVariableRequest?, TResult>? @string = null,
            global::System.Func<global::ElevenLabs.CreateSecretEnvironmentVariableRequest?, TResult>? secret = null,
            global::System.Func<global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest?, TResult>? authConnection = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsSecret && secret != null)
            {
                return secret(Secret!);
            }
            else if (IsAuthConnection && authConnection != null)
            {
                return authConnection(AuthConnection!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.CreateStringEnvironmentVariableRequest?>? @string = null,
            global::System.Action<global::ElevenLabs.CreateSecretEnvironmentVariableRequest?>? secret = null,
            global::System.Action<global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest?>? authConnection = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsSecret)
            {
                secret?.Invoke(Secret!);
            }
            else if (IsAuthConnection)
            {
                authConnection?.Invoke(AuthConnection!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::ElevenLabs.CreateStringEnvironmentVariableRequest),
                Secret,
                typeof(global::ElevenLabs.CreateSecretEnvironmentVariableRequest),
                AuthConnection,
                typeof(global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest),
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
        public bool Equals(CreateEnvironmentVariableRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateStringEnvironmentVariableRequest?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateSecretEnvironmentVariableRequest?>.Default.Equals(Secret, other.Secret) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CreateAuthConnectionEnvironmentVariableRequest?>.Default.Equals(AuthConnection, other.AuthConnection) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateEnvironmentVariableRequest obj1, CreateEnvironmentVariableRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateEnvironmentVariableRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateEnvironmentVariableRequest obj1, CreateEnvironmentVariableRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateEnvironmentVariableRequest o && Equals(o);
        }
    }
}
