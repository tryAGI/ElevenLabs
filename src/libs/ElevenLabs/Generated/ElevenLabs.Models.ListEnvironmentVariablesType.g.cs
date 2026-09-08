
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ListEnvironmentVariablesType
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
    public static class ListEnvironmentVariablesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEnvironmentVariablesType value)
        {
            return value switch
            {
                ListEnvironmentVariablesType.AuthConnection => "auth_connection",
                ListEnvironmentVariablesType.Secret => "secret",
                ListEnvironmentVariablesType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEnvironmentVariablesType? ToEnum(string value)
        {
            return value switch
            {
                "auth_connection" => ListEnvironmentVariablesType.AuthConnection,
                "secret" => ListEnvironmentVariablesType.Secret,
                "string" => ListEnvironmentVariablesType.String,
                _ => null,
            };
        }
    }
}