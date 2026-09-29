
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentMergeProposalResponseOutcomeDiscriminatorStatus
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
    public static class AgentMergeProposalResponseOutcomeDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentMergeProposalResponseOutcomeDiscriminatorStatus value)
        {
            return value switch
            {
                AgentMergeProposalResponseOutcomeDiscriminatorStatus.Closed => "closed",
                AgentMergeProposalResponseOutcomeDiscriminatorStatus.Merged => "merged",
                AgentMergeProposalResponseOutcomeDiscriminatorStatus.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentMergeProposalResponseOutcomeDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "closed" => AgentMergeProposalResponseOutcomeDiscriminatorStatus.Closed,
                "merged" => AgentMergeProposalResponseOutcomeDiscriminatorStatus.Merged,
                "open" => AgentMergeProposalResponseOutcomeDiscriminatorStatus.Open,
                _ => null,
            };
        }
    }
}