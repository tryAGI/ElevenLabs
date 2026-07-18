
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch
    {
        /// <summary>
        /// Whether to disable or enable the webhook
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDisabled { get; set; }

        /// <summary>
        /// The display name of the webhook (used for display purposes only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether to enable automatic retries for transient failures (5xx, 429, timeout)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_enabled")]
        public bool? RetryEnabled { get; set; }

        /// <summary>
        /// A list of request headers to include with the webhook delivery (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestHeaders { get; set; }

        /// <summary>
        /// The complete set of workspace-level events this webhook should be subscribed to. The webhook is added to the events in the list and removed from any not in the list. Omit to leave the current event subscriptions unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookEventType>? Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch" /> class.
        /// </summary>
        /// <param name="isDisabled">
        /// Whether to disable or enable the webhook
        /// </param>
        /// <param name="name">
        /// The display name of the webhook (used for display purposes only).
        /// </param>
        /// <param name="retryEnabled">
        /// Whether to enable automatic retries for transient failures (5xx, 429, timeout)
        /// </param>
        /// <param name="requestHeaders">
        /// A list of request headers to include with the webhook delivery (optional)
        /// </param>
        /// <param name="events">
        /// The complete set of workspace-level events this webhook should be subscribed to. The webhook is added to the events in the list and removed from any not in the list. Omit to leave the current event subscriptions unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch(
            bool isDisabled,
            string name,
            bool? retryEnabled,
            global::System.Collections.Generic.Dictionary<string, string>? requestHeaders,
            global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceWebhookEventType>? events)
        {
            this.IsDisabled = isDisabled;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RetryEnabled = retryEnabled;
            this.RequestHeaders = requestHeaders;
            this.Events = events;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch" /> class.
        /// </summary>
        public BodyUpdateWorkspaceWebhookV1WorkspaceWebhooksWebhookIdPatch()
        {
        }

    }
}