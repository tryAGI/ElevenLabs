
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum MergeProposalStatus
    {
        /// <summary>
        ///
        /// </summary>
        Closed,
        /// <summary>
        ///
        /// </summary>
        Merged,
        /// <summary>
        ///
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MergeProposalStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MergeProposalStatus value)
        {
            return value switch
            {
                MergeProposalStatus.Closed => "closed",
                MergeProposalStatus.Merged => "merged",
                MergeProposalStatus.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MergeProposalStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => MergeProposalStatus.Closed,
                "merged" => MergeProposalStatus.Merged,
                "open" => MergeProposalStatus.Open,
                _ => null,
            };
        }
    }
}