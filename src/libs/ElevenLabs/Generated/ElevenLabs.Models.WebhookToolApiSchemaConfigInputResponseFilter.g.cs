
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Optional allow-list filter applied to the response before the LLM sees it, so large responses don't pollute the context. Defaults to the full response.
    /// </summary>
    public sealed partial class WebhookToolApiSchemaConfigInputResponseFilter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}