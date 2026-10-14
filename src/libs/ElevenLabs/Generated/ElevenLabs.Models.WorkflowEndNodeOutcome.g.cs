
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Whether reaching an End node completes successfully or fails.<br/>
    /// Default Value: success
    /// </summary>
    public enum WorkflowEndNodeOutcome
    {
        /// <summary>
        ///
        /// </summary>
        Failure,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowEndNodeOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowEndNodeOutcome value)
        {
            return value switch
            {
                WorkflowEndNodeOutcome.Failure => "failure",
                WorkflowEndNodeOutcome.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowEndNodeOutcome? ToEnum(string value)
        {
            return value switch
            {
                "failure" => WorkflowEndNodeOutcome.Failure,
                "success" => WorkflowEndNodeOutcome.Success,
                _ => null,
            };
        }
    }
}