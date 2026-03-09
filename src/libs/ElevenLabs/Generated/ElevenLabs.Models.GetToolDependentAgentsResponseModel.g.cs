
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolDependentAgentsResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem3> Agents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolDependentAgentsResponseModel" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolDependentAgentsResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentsItem3> agents,
            bool hasMore,
            string? nextCursor)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolDependentAgentsResponseModel" /> class.
        /// </summary>
        public GetToolDependentAgentsResponseModel()
        {
        }
    }
}