
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalCriterionRequest
    {
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
        public required global::System.Collections.Generic.IList<global::ElevenLabs.CriterionItemRequest> Criteria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_extraction_config")]
        public global::ElevenLabs.DataExtractionConfigRequestInput? DataExtractionConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCriterionRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="criteria"></param>
        /// <param name="dataExtractionConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalCriterionRequest(
            string name,
            global::System.Collections.Generic.IList<global::ElevenLabs.CriterionItemRequest> criteria,
            global::ElevenLabs.DataExtractionConfigRequestInput? dataExtractionConfig)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Criteria = criteria ?? throw new global::System.ArgumentNullException(nameof(criteria));
            this.DataExtractionConfig = dataExtractionConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalCriterionRequest" /> class.
        /// </summary>
        public CreateEvalCriterionRequest()
        {
        }
    }
}