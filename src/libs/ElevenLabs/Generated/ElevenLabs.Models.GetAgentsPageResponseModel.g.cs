
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAgentsPageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AgentSummaryResponseModel> Agents { get; set; }

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
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentsPageResponseModel" /> class.
        /// </summary>
        /// <param name="agents"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetAgentsPageResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.AgentSummaryResponseModel> agents,
            bool hasMore,
            string? nextCursor)
        {
            this.Agents = agents ?? throw new global::System.ArgumentNullException(nameof(agents));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAgentsPageResponseModel" /> class.
        /// </summary>
        public GetAgentsPageResponseModel()
        {
        }
    }
}