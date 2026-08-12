
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Deliver the result to specific configured flows webhooks.
    /// </summary>
    public sealed partial class WebhookTargetIds
    {
        /// <summary>
        /// Send the result to the listed flows webhooks.<br/>
        /// Default Value: ids
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The IDs of the workspace flows webhooks to deliver the result to. Each must be one of the workspace's configured flows webhooks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTargetIds" /> class.
        /// </summary>
        /// <param name="ids">
        /// The IDs of the workspace flows webhooks to deliver the result to. Each must be one of the workspace's configured flows webhooks.
        /// </param>
        /// <param name="type">
        /// Send the result to the listed flows webhooks.<br/>
        /// Default Value: ids
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookTargetIds(
            global::System.Collections.Generic.IList<string> ids,
            string? type)
        {
            this.Type = type;
            this.Ids = ids ?? throw new global::System.ArgumentNullException(nameof(ids));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookTargetIds" /> class.
        /// </summary>
        public WebhookTargetIds()
        {
        }

    }
}