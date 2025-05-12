
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentSimulatedChatTestResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulated_conversation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput> SimulatedConversation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConversationHistoryAnalysisCommonModel Analysis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSimulatedChatTestResponseModel" /> class.
        /// </summary>
        /// <param name="simulatedConversation"></param>
        /// <param name="analysis"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSimulatedChatTestResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.ConversationHistoryTranscriptCommonModelOutput> simulatedConversation,
            global::ElevenLabs.ConversationHistoryAnalysisCommonModel analysis)
        {
            this.SimulatedConversation = simulatedConversation ?? throw new global::System.ArgumentNullException(nameof(simulatedConversation));
            this.Analysis = analysis ?? throw new global::System.ArgumentNullException(nameof(analysis));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSimulatedChatTestResponseModel" /> class.
        /// </summary>
        public AgentSimulatedChatTestResponseModel()
        {
        }
    }
}