
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Deliver the result to all of the workspace's configured flows webhooks.
    /// </summary>
    public sealed partial class WebhookTargetAll
    {
        /// <summary>
        /// Send the result to all of the workspace's configured flows webhooks.
        /// </summary>
        /// <default>"all"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "all";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTargetAll" /> class.
        /// </summary>
        /// <param name="type">
        /// Send the result to all of the workspace's configured flows webhooks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookTargetAll(
            string type = "all")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTargetAll" /> class.
        /// </summary>
        public WebhookTargetAll()
        {
        }

    }
}