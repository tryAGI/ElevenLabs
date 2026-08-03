
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnalysisType
    {
        /// <summary>
        /// 
        /// </summary>
        DataCollection,
        /// <summary>
        /// 
        /// </summary>
        EvaluationCriteria,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnalysisTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnalysisType value)
        {
            return value switch
            {
                AnalysisType.DataCollection => "data_collection",
                AnalysisType.EvaluationCriteria => "evaluation_criteria",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnalysisType? ToEnum(string value)
        {
            return value switch
            {
                "data_collection" => AnalysisType.DataCollection,
                "evaluation_criteria" => AnalysisType.EvaluationCriteria,
                _ => null,
            };
        }
    }
}