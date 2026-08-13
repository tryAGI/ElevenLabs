
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The plain chat messages (role and text only). Included only when message_count does not exceed the requested max_messages; otherwise null and messages_omitted is true.
    /// </summary>
    public sealed partial class GetConversationSummaryResponseModelMessages
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}