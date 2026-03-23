
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListEnvironmentVariablesType2
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
    public static class ListEnvironmentVariablesType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListEnvironmentVariablesType2 value)
        {
            return value switch
            {
                ListEnvironmentVariablesType2.AuthConnection => "auth_connection",
                ListEnvironmentVariablesType2.Secret => "secret",
                ListEnvironmentVariablesType2.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListEnvironmentVariablesType2? ToEnum(string value)
        {
            return value switch
            {
                "auth_connection" => ListEnvironmentVariablesType2.AuthConnection,
                "secret" => ListEnvironmentVariablesType2.Secret,
                "string" => ListEnvironmentVariablesType2.String,
                _ => null,
            };
        }
    }
}