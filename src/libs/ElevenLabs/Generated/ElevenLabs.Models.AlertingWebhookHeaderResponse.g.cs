
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertingWebhookHeaderResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSecret { get; set; }

        /// <summary>
        /// The header value. Always null for secret headers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingWebhookHeaderResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isSecret"></param>
        /// <param name="value">
        /// The header value. Always null for secret headers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingWebhookHeaderResponse(
            string name,
            bool isSecret,
            string? value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsSecret = isSecret;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingWebhookHeaderResponse" /> class.
        /// </summary>
        public AlertingWebhookHeaderResponse()
        {
        }

    }
}