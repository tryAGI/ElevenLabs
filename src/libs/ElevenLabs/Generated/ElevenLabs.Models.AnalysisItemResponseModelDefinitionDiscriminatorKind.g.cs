
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalysisItemResponseModelDefinitionDiscriminatorKind
    {
        /// <summary>
        ///
        /// </summary>
        DataCollection,
        /// <summary>
        ///
        /// </summary>
        Evaluation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalysisItemResponseModelDefinitionDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalysisItemResponseModelDefinitionDiscriminatorKind value)
        {
            return value switch
            {
                AnalysisItemResponseModelDefinitionDiscriminatorKind.DataCollection => "data_collection",
                AnalysisItemResponseModelDefinitionDiscriminatorKind.Evaluation => "evaluation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalysisItemResponseModelDefinitionDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "data_collection" => AnalysisItemResponseModelDefinitionDiscriminatorKind.DataCollection,
                "evaluation" => AnalysisItemResponseModelDefinitionDiscriminatorKind.Evaluation,
                _ => null,
            };
        }
    }
}