
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvAIWebhooks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("post_call_webhook_id")]
        public string? PostCallWebhookId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWebhooks" /> class.
        /// </summary>
        /// <param name="postCallWebhookId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvAIWebhooks(
            string? postCallWebhookId)
        {
            this.PostCallWebhookId = postCallWebhookId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAIWebhooks" /> class.
        /// </summary>
        public ConvAIWebhooks()
        {
        }
    }
}