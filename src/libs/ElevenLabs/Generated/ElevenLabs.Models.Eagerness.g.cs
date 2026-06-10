
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum Eagerness
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EagernessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Eagerness value)
        {
            return value switch
            {
                Eagerness.High => "high",
                Eagerness.Low => "low",
                Eagerness.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Eagerness? ToEnum(string value)
        {
            return value switch
            {
                "high" => Eagerness.High,
                "low" => Eagerness.Low,
                "medium" => Eagerness.Medium,
                _ => null,
            };
        }
    }
}