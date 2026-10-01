
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentDeploymentSource
    {
        /// <summary>
        ///
        /// </summary>
        BranchMerge,
        /// <summary>
        ///
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentDeploymentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentDeploymentSource value)
        {
            return value switch
            {
                AgentDeploymentSource.BranchMerge => "branch_merge",
                AgentDeploymentSource.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentDeploymentSource? ToEnum(string value)
        {
            return value switch
            {
                "branch_merge" => AgentDeploymentSource.BranchMerge,
                "manual" => AgentDeploymentSource.Manual,
                _ => null,
            };
        }
    }
}