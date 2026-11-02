
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalysisItemVersionResponseModelDefinitionDiscriminatorKind
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
    public static class AnalysisItemVersionResponseModelDefinitionDiscriminatorKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalysisItemVersionResponseModelDefinitionDiscriminatorKind value)
        {
            return value switch
            {
                AnalysisItemVersionResponseModelDefinitionDiscriminatorKind.DataCollection => "data_collection",
                AnalysisItemVersionResponseModelDefinitionDiscriminatorKind.Evaluation => "evaluation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalysisItemVersionResponseModelDefinitionDiscriminatorKind? ToEnum(string value)
        {
            return value switch
            {
                "data_collection" => AnalysisItemVersionResponseModelDefinitionDiscriminatorKind.DataCollection,
                "evaluation" => AnalysisItemVersionResponseModelDefinitionDiscriminatorKind.Evaluation,
                _ => null,
            };
        }
    }
}