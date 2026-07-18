
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Canonical representation of a knowledge base document's stored content.<br/>
    /// HTML is the legacy default; documents created before this field existed are<br/>
    /// interpreted as HTML.<br/>
    /// Default Value: html
    /// </summary>
    public enum ContentFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFormat value)
        {
            return value switch
            {
                ContentFormat.Html => "html",
                ContentFormat.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFormat? ToEnum(string value)
        {
            return value switch
            {
                "html" => ContentFormat.Html,
                "markdown" => ContentFormat.Markdown,
                _ => null,
            };
        }
    }
}