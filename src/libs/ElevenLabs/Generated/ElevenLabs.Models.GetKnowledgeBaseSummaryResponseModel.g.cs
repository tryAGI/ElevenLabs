
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetKnowledgeBaseSummaryResponseModel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryResponseModelTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.GetKnowledgeBaseSummaryResponseModelType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependent_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem> DependentAgents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GetKnowledgeBaseSummaryResponseModelAccessLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.GetKnowledgeBaseSummaryResponseModelAccessLevel AccessLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="dependentAgents"></param>
        /// <param name="accessLevel"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetKnowledgeBaseSummaryResponseModel(
            string id,
            string name,
            global::ElevenLabs.GetKnowledgeBaseSummaryResponseModelType type,
            global::System.Collections.Generic.IList<global::ElevenLabs.DependentAgentsItem> dependentAgents,
            global::ElevenLabs.GetKnowledgeBaseSummaryResponseModelAccessLevel accessLevel)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.DependentAgents = dependentAgents ?? throw new global::System.ArgumentNullException(nameof(dependentAgents));
            this.AccessLevel = accessLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetKnowledgeBaseSummaryResponseModel" /> class.
        /// </summary>
        public GetKnowledgeBaseSummaryResponseModel()
        {
        }
    }
}