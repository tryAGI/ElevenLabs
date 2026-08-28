
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum ExperimentAssignmentSource
    {
        /// <summary>
        ///
        /// </summary>
        ClientDeclared,
        /// <summary>
        ///
        /// </summary>
        ServerBranch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentAssignmentSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentAssignmentSource value)
        {
            return value switch
            {
                ExperimentAssignmentSource.ClientDeclared => "client_declared",
                ExperimentAssignmentSource.ServerBranch => "server_branch",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentAssignmentSource? ToEnum(string value)
        {
            return value switch
            {
                "client_declared" => ExperimentAssignmentSource.ClientDeclared,
                "server_branch" => ExperimentAssignmentSource.ServerBranch,
                _ => null,
            };
        }
    }
}