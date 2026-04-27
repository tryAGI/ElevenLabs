
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum MutationResultCreatedNodesVariant1ItemDiscriminatorType
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
    public static class MutationResultCreatedNodesVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MutationResultCreatedNodesVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                MutationResultCreatedNodesVariant1ItemDiscriminatorType.Generation => "generation",
                MutationResultCreatedNodesVariant1ItemDiscriminatorType.StaticAsset => "static_asset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MutationResultCreatedNodesVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "generation" => MutationResultCreatedNodesVariant1ItemDiscriminatorType.Generation,
                "static_asset" => MutationResultCreatedNodesVariant1ItemDiscriminatorType.StaticAsset,
                _ => null,
            };
        }
    }
}