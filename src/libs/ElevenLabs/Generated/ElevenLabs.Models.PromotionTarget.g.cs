
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Default Value: service
    /// </summary>
    public enum PromotionTarget
    {
        /// <summary>
        ///
        /// </summary>
        AddOn,
        /// <summary>
        ///
        /// </summary>
        Service,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromotionTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotionTarget value)
        {
            return value switch
            {
                PromotionTarget.AddOn => "add_on",
                PromotionTarget.Service => "service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotionTarget? ToEnum(string value)
        {
            return value switch
            {
                "add_on" => PromotionTarget.AddOn,
                "service" => PromotionTarget.Service,
                _ => null,
            };
        }
    }
}