
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateEnvironmentVariableRequestDiscriminatorType
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
    public static class CreateEnvironmentVariableRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnvironmentVariableRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateEnvironmentVariableRequestDiscriminatorType.String => "string",
                CreateEnvironmentVariableRequestDiscriminatorType.Secret => "secret",
                CreateEnvironmentVariableRequestDiscriminatorType.AuthConnection => "auth_connection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEnvironmentVariableRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "string" => CreateEnvironmentVariableRequestDiscriminatorType.String,
                "secret" => CreateEnvironmentVariableRequestDiscriminatorType.Secret,
                "auth_connection" => CreateEnvironmentVariableRequestDiscriminatorType.AuthConnection,
                _ => null,
            };
        }
    }
}