
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Number of commits on main not yet incorporated into this branch, relative to their common ancestor. Null if it could not be computed (e.g. no common ancestor, or the branch history exceeds the comparison budget).
    /// </summary>
    public sealed partial class AgentBranchSummaryCommitsBehind
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}