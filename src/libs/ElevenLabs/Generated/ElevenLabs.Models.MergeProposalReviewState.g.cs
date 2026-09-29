
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum MergeProposalReviewState
    {
        /// <summary>
        ///
        /// </summary>
        Approved,
        /// <summary>
        ///
        /// </summary>
        ChangesRequested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MergeProposalReviewStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MergeProposalReviewState value)
        {
            return value switch
            {
                MergeProposalReviewState.Approved => "approved",
                MergeProposalReviewState.ChangesRequested => "changes_requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MergeProposalReviewState? ToEnum(string value)
        {
            return value switch
            {
                "approved" => MergeProposalReviewState.Approved,
                "changes_requested" => MergeProposalReviewState.ChangesRequested,
                _ => null,
            };
        }
    }
}