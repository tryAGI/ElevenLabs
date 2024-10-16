
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectExtendedResponseModelState
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Converting,
        /// <summary>
        /// 
        /// </summary>
        InQueue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectExtendedResponseModelStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelState value)
        {
            return value switch
            {
                ProjectExtendedResponseModelState.Default => "default",
                ProjectExtendedResponseModelState.Converting => "converting",
                ProjectExtendedResponseModelState.InQueue => "in_queue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelState? ToEnum(string value)
        {
            return value switch
            {
                "default" => ProjectExtendedResponseModelState.Default,
                "converting" => ProjectExtendedResponseModelState.Converting,
                "in_queue" => ProjectExtendedResponseModelState.InQueue,
                _ => null,
            };
        }
    }
}