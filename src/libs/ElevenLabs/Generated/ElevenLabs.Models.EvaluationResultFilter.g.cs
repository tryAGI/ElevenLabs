
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum EvaluationResultFilter
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EvaluationResultFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EvaluationResultFilter value)
        {
            return value switch
            {
                EvaluationResultFilter.Error => "error",
                EvaluationResultFilter.Failure => "failure",
                EvaluationResultFilter.Success => "success",
                EvaluationResultFilter.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EvaluationResultFilter? ToEnum(string value)
        {
            return value switch
            {
                "error" => EvaluationResultFilter.Error,
                "failure" => EvaluationResultFilter.Failure,
                "success" => EvaluationResultFilter.Success,
                "unknown" => EvaluationResultFilter.Unknown,
                _ => null,
            };
        }
    }
}