
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolResponseModelToolConfigDiscriminatorType
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
    public static class ToolResponseModelToolConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolResponseModelToolConfigDiscriminatorType value)
        {
            return value switch
            {
                ToolResponseModelToolConfigDiscriminatorType.Webhook => "webhook",
                ToolResponseModelToolConfigDiscriminatorType.Client => "client",
                ToolResponseModelToolConfigDiscriminatorType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolResponseModelToolConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => ToolResponseModelToolConfigDiscriminatorType.Webhook,
                "client" => ToolResponseModelToolConfigDiscriminatorType.Client,
                "system" => ToolResponseModelToolConfigDiscriminatorType.System,
                _ => null,
            };
        }
    }
}