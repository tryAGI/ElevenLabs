
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Whether a discovered MCP tool has an approval and whether it still matches.
    /// </summary>
    public enum MCPToolApprovalState
    {
        /// <summary>
        ///
        /// </summary>
        NeedsReview,
        /// <summary>
        ///
        /// </summary>
        NotApproved,
        /// <summary>
        ///
        /// </summary>
        UpToDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MCPToolApprovalStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MCPToolApprovalState value)
        {
            return value switch
            {
                MCPToolApprovalState.NeedsReview => "needs_review",
                MCPToolApprovalState.NotApproved => "not_approved",
                MCPToolApprovalState.UpToDate => "up_to_date",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MCPToolApprovalState? ToEnum(string value)
        {
            return value switch
            {
                "needs_review" => MCPToolApprovalState.NeedsReview,
                "not_approved" => MCPToolApprovalState.NotApproved,
                "up_to_date" => MCPToolApprovalState.UpToDate,
                _ => null,
            };
        }
    }
}