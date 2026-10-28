
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Preset tone for an SMS message body.
    /// </summary>
    public enum SmsTemplateStyle
    {
        /// <summary>
        ///
        /// </summary>
        Concise,
        /// <summary>
        ///
        /// </summary>
        Friendly,
        /// <summary>
        ///
        /// </summary>
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SmsTemplateStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SmsTemplateStyle value)
        {
            return value switch
            {
                SmsTemplateStyle.Concise => "concise",
                SmsTemplateStyle.Friendly => "friendly",
                SmsTemplateStyle.Professional => "professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SmsTemplateStyle? ToEnum(string value)
        {
            return value switch
            {
                "concise" => SmsTemplateStyle.Concise,
                "friendly" => SmsTemplateStyle.Friendly,
                "professional" => SmsTemplateStyle.Professional,
                _ => null,
            };
        }
    }
}