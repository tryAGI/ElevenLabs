
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptToolCallIntegrationFunctionDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> ResolvedParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallIntegrationFunctionDetails" /> class.
        /// </summary>
        /// <param name="resolvedParameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryTranscriptToolCallIntegrationFunctionDetails(
            global::System.Collections.Generic.Dictionary<string, string> resolvedParameters)
        {
            this.ResolvedParameters = resolvedParameters ?? throw new global::System.ArgumentNullException(nameof(resolvedParameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallIntegrationFunctionDetails" /> class.
        /// </summary>
        public ConversationHistoryTranscriptToolCallIntegrationFunctionDetails()
        {
        }

    }
}