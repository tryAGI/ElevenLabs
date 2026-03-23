
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
        AuthConnection,
        /// <summary>
        /// 
        /// </summary>
        Secret,
        /// <summary>
        /// 
        /// </summary>
        String,
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
                EnvironmentVariableResponseType.AuthConnection => "auth_connection",
                EnvironmentVariableResponseType.Secret => "secret",
                EnvironmentVariableResponseType.String => "string",
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
                "auth_connection" => EnvironmentVariableResponseType.AuthConnection,
                "secret" => EnvironmentVariableResponseType.Secret,
                "string" => EnvironmentVariableResponseType.String,
                _ => null,
            };
        }
    }
}