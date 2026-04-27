
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum MutationResultNodeVariant1DiscriminatorType
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
    public static class MutationResultNodeVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MutationResultNodeVariant1DiscriminatorType value)
        {
            return value switch
            {
                MutationResultNodeVariant1DiscriminatorType.Generation => "generation",
                MutationResultNodeVariant1DiscriminatorType.StaticAsset => "static_asset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MutationResultNodeVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "generation" => MutationResultNodeVariant1DiscriminatorType.Generation,
                "static_asset" => MutationResultNodeVariant1DiscriminatorType.StaticAsset,
                _ => null,
            };
        }
    }
}