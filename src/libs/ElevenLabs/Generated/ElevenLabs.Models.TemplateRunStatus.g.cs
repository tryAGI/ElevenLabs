
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Where a run, or one of its outputs, is in its lifecycle. The run's is rolled<br/>
    /// up from its outputs' (``aggregate_output_statuses``). A class rather than a<br/>
    /// ``Literal`` so it publishes as one named enum instead of being inlined into<br/>
    /// every kind.
    /// </summary>
    public enum TemplateRunStatus
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Generating,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateRunStatus value)
        {
            return value switch
            {
                TemplateRunStatus.Completed => "completed",
                TemplateRunStatus.Failed => "failed",
                TemplateRunStatus.Generating => "generating",
                TemplateRunStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => TemplateRunStatus.Completed,
                "failed" => TemplateRunStatus.Failed,
                "generating" => TemplateRunStatus.Generating,
                "pending" => TemplateRunStatus.Pending,
                _ => null,
            };
        }
    }
}