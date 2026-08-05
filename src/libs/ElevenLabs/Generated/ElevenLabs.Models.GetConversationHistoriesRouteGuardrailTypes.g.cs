
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Filter to conversations where a guardrail of any of these types triggered (metadata.triggered_guardrails.guardrail_type). Repeat param to match any of several.
    /// </summary>
    public sealed partial class GetConversationHistoriesRouteGuardrailTypes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}