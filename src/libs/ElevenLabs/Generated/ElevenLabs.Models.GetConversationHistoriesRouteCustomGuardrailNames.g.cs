
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Filter to conversations where a custom guardrail with any of these names triggered (metadata.triggered_guardrails.guardrail_name). Only custom guardrails carry a name. Repeat param to match any of several.
    /// </summary>
    public sealed partial class GetConversationHistoriesRouteCustomGuardrailNames
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}