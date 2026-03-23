
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalCriterionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("criteria")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Criteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_extraction_config")]
        public global::ElevenLabs.DataExtractionConfigRequestOutput? DataExtractionConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalCriterionResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="workspaceId"></param>
        /// <param name="name"></param>
        /// <param name="criteria"></param>
        /// <param name="dataExtractionConfig"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalCriterionResponse(
            string id,
            string workspaceId,
            string name,
            global::System.Collections.Generic.IList<object> criteria,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::ElevenLabs.DataExtractionConfigRequestOutput? dataExtractionConfig)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DataExtractionConfig = dataExtractionConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalCriterionResponse" /> class.
        /// </summary>
        public EvalCriterionResponse()
        {
        }
    }
}