
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum FlowStateResultNodeDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Generation,
        /// <summary>
        /// 
        /// </summary>
        StaticAsset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FlowStateResultNodeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FlowStateResultNodeDiscriminatorType value)
        {
            return value switch
            {
                FlowStateResultNodeDiscriminatorType.Generation => "generation",
                FlowStateResultNodeDiscriminatorType.StaticAsset => "static_asset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FlowStateResultNodeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "generation" => FlowStateResultNodeDiscriminatorType.Generation,
                "static_asset" => FlowStateResultNodeDiscriminatorType.StaticAsset,
                _ => null,
            };
        }
    }
}