
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum MergeProposalCloseReason
    {
        /// <summary>
        ///
        /// </summary>
        BranchArchived,
        /// <summary>
        ///
        /// </summary>
        Rejected,
        /// <summary>
        ///
        /// </summary>
        Withdrawn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MergeProposalCloseReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MergeProposalCloseReason value)
        {
            return value switch
            {
                MergeProposalCloseReason.BranchArchived => "branch_archived",
                MergeProposalCloseReason.Rejected => "rejected",
                MergeProposalCloseReason.Withdrawn => "withdrawn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MergeProposalCloseReason? ToEnum(string value)
        {
            return value switch
            {
                "branch_archived" => MergeProposalCloseReason.BranchArchived,
                "rejected" => MergeProposalCloseReason.Rejected,
                "withdrawn" => MergeProposalCloseReason.Withdrawn,
                _ => null,
            };
        }
    }
}