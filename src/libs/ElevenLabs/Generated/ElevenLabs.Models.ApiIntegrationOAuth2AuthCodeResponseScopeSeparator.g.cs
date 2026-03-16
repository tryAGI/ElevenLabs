
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Separator for scopes
    /// </summary>
    public enum ApiIntegrationOAuth2AuthCodeResponseScopeSeparator
    {
        /// <summary>
        /// 
        /// </summary>
        x_,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiIntegrationOAuth2AuthCodeResponseScopeSeparatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiIntegrationOAuth2AuthCodeResponseScopeSeparator value)
        {
            return value switch
            {
                ApiIntegrationOAuth2AuthCodeResponseScopeSeparator.x_ => ",",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiIntegrationOAuth2AuthCodeResponseScopeSeparator? ToEnum(string value)
        {
            return value switch
            {
                "," => ApiIntegrationOAuth2AuthCodeResponseScopeSeparator.x_,
                _ => null,
            };
        }
    }
}