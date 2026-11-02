
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AnalysisItemKind
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
    public static class AnalysisItemKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalysisItemKind value)
        {
            return value switch
            {
                AnalysisItemKind.DataCollection => "data_collection",
                AnalysisItemKind.Evaluation => "evaluation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalysisItemKind? ToEnum(string value)
        {
            return value switch
            {
                "data_collection" => AnalysisItemKind.DataCollection,
                "evaluation" => AnalysisItemKind.Evaluation,
                _ => null,
            };
        }
    }
}