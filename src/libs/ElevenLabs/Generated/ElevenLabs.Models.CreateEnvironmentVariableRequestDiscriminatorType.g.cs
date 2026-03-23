
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
    public static class CreateEnvironmentVariableRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEnvironmentVariableRequestDiscriminatorType value)
        {
            return value switch
            {
                CreateEnvironmentVariableRequestDiscriminatorType.AuthConnection => "auth_connection",
                CreateEnvironmentVariableRequestDiscriminatorType.Secret => "secret",
                CreateEnvironmentVariableRequestDiscriminatorType.String => "string",
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
                "auth_connection" => CreateEnvironmentVariableRequestDiscriminatorType.AuthConnection,
                "secret" => CreateEnvironmentVariableRequestDiscriminatorType.Secret,
                "string" => CreateEnvironmentVariableRequestDiscriminatorType.String,
                _ => null,
            };
        }
    }
}