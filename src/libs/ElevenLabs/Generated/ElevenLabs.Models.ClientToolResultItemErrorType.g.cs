
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ClientToolResultItemErrorType
    {
        /// <summary>
        ///
        /// </summary>
        ClientTimeout,
        /// <summary>
        ///
        /// </summary>
        CustomerAuth,
        /// <summary>
        ///
        /// </summary>
        ExternalClient,
        /// <summary>
        ///
        /// </summary>
        ExternalServer,
        /// <summary>
        ///
        /// </summary>
        Unknown,
        /// <summary>
        ///
        /// </summary>
        UserRejected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientToolResultItemErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientToolResultItemErrorType value)
        {
            return value switch
            {
                ClientToolResultItemErrorType.ClientTimeout => "client_timeout",
                ClientToolResultItemErrorType.CustomerAuth => "customer_auth",
                ClientToolResultItemErrorType.ExternalClient => "external_client",
                ClientToolResultItemErrorType.ExternalServer => "external_server",
                ClientToolResultItemErrorType.Unknown => "unknown",
                ClientToolResultItemErrorType.UserRejected => "user_rejected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientToolResultItemErrorType? ToEnum(string value)
        {
            return value switch
            {
                "client_timeout" => ClientToolResultItemErrorType.ClientTimeout,
                "customer_auth" => ClientToolResultItemErrorType.CustomerAuth,
                "external_client" => ClientToolResultItemErrorType.ExternalClient,
                "external_server" => ClientToolResultItemErrorType.ExternalServer,
                "unknown" => ClientToolResultItemErrorType.Unknown,
                "user_rejected" => ClientToolResultItemErrorType.UserRejected,
                _ => null,
            };
        }
    }
}