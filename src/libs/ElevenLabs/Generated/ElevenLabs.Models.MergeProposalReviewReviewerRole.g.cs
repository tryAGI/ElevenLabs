
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum MergeProposalReviewReviewerRole
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Commenter,
        /// <summary>
        ///
        /// </summary>
        Editor,
        /// <summary>
        ///
        /// </summary>
        Viewer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MergeProposalReviewReviewerRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MergeProposalReviewReviewerRole value)
        {
            return value switch
            {
                MergeProposalReviewReviewerRole.Admin => "admin",
                MergeProposalReviewReviewerRole.Commenter => "commenter",
                MergeProposalReviewReviewerRole.Editor => "editor",
                MergeProposalReviewReviewerRole.Viewer => "viewer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MergeProposalReviewReviewerRole? ToEnum(string value)
        {
            return value switch
            {
                "admin" => MergeProposalReviewReviewerRole.Admin,
                "commenter" => MergeProposalReviewReviewerRole.Commenter,
                "editor" => MergeProposalReviewReviewerRole.Editor,
                "viewer" => MergeProposalReviewReviewerRole.Viewer,
                _ => null,
            };
        }
    }
}