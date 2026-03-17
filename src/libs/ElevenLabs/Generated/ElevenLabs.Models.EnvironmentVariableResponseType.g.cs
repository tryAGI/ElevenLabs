
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentVariableResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        Secret,
        /// <summary>
        /// 
        /// </summary>
        AuthConnection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentVariableResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentVariableResponseType value)
        {
            return value switch
            {
                EnvironmentVariableResponseType.String => "string",
                EnvironmentVariableResponseType.Secret => "secret",
                EnvironmentVariableResponseType.AuthConnection => "auth_connection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentVariableResponseType? ToEnum(string value)
        {
            return value switch
            {
                "string" => EnvironmentVariableResponseType.String,
                "secret" => EnvironmentVariableResponseType.Secret,
                "auth_connection" => EnvironmentVariableResponseType.AuthConnection,
                _ => null,
            };
        }
    }
}