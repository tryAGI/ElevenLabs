
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentMetadataResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMetadataResponseModel" /> class.
        /// </summary>
        /// <param name="createdAtUnixSecs"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AgentMetadataResponseModel(
            int createdAtUnixSecs)
        {
            this.CreatedAtUnixSecs = createdAtUnixSecs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentMetadataResponseModel" /> class.
        /// </summary>
        public AgentMetadataResponseModel()
        {
        }
    }
}