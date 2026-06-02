
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Why a node is included in a generation run.
    /// </summary>
    public enum NodeRunReason
    {
        /// <summary>
        /// 
        /// </summary>
        IsMissingDependentDependency,
        /// <summary>
        /// 
        /// </summary>
        IsMissingTargetDependency,
        /// <summary>
        /// 
        /// </summary>
        IsRequestedDependency,
        /// <summary>
        /// 
        /// </summary>
        IsRequestedDependent,
        /// <summary>
        /// 
        /// </summary>
        IsTarget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NodeRunReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NodeRunReason value)
        {
            return value switch
            {
                NodeRunReason.IsMissingDependentDependency => "is_missing_dependent_dependency",
                NodeRunReason.IsMissingTargetDependency => "is_missing_target_dependency",
                NodeRunReason.IsRequestedDependency => "is_requested_dependency",
                NodeRunReason.IsRequestedDependent => "is_requested_dependent",
                NodeRunReason.IsTarget => "is_target",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NodeRunReason? ToEnum(string value)
        {
            return value switch
            {
                "is_missing_dependent_dependency" => NodeRunReason.IsMissingDependentDependency,
                "is_missing_target_dependency" => NodeRunReason.IsMissingTargetDependency,
                "is_requested_dependency" => NodeRunReason.IsRequestedDependency,
                "is_requested_dependent" => NodeRunReason.IsRequestedDependent,
                "is_target" => NodeRunReason.IsTarget,
                _ => null,
            };
        }
    }
}