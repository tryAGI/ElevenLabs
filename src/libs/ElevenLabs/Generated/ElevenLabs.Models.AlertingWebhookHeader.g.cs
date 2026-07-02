
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertingWebhookHeader
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_secret")]
        public bool? IsSecret { get; set; }

        /// <summary>
        /// Header value. May be null only for a secret header on update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingWebhookHeader" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isSecret">
        /// Default Value: false
        /// </param>
        /// <param name="value">
        /// Header value. May be null only for a secret header on update.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingWebhookHeader(
            string name,
            bool? isSecret,
            string? value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsSecret = isSecret;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingWebhookHeader" /> class.
        /// </summary>
        public AlertingWebhookHeader()
        {
        }

    }
}