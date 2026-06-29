
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationReasoningModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_redact")]
        public bool? ProviderRedact { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationReasoningModel" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="providerRedact">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationReasoningModel(
            string? summary,
            bool? providerRedact)
        {
            this.Summary = summary;
            this.ProviderRedact = providerRedact;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationReasoningModel" /> class.
        /// </summary>
        public ConversationReasoningModel()
        {
        }

    }
}