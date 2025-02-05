
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolRequestModelToolConfigDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRequestModelToolConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRequestModelToolConfigDiscriminatorType value)
        {
            return value switch
            {
                ToolRequestModelToolConfigDiscriminatorType.Webhook => "webhook",
                ToolRequestModelToolConfigDiscriminatorType.Client => "client",
                ToolRequestModelToolConfigDiscriminatorType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRequestModelToolConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ToolRequestModelToolConfigDiscriminatorType.Webhook,
                "client" => ToolRequestModelToolConfigDiscriminatorType.Client,
                "system" => ToolRequestModelToolConfigDiscriminatorType.System,
                _ => null,
            };
        }
    }
}