
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A custom webhook header value, encrypted at rest.
    /// </summary>
    public sealed partial class AlertingWebhookSecretHeaderValue
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EncryptedValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nonce")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nonce { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingWebhookSecretHeaderValue" /> class.
        /// </summary>
        /// <param name="encryptedValue"></param>
        /// <param name="nonce"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertingWebhookSecretHeaderValue(
            string encryptedValue,
            string nonce)
        {
            this.EncryptedValue = encryptedValue ?? throw new global::System.ArgumentNullException(nameof(encryptedValue));
            this.Nonce = nonce ?? throw new global::System.ArgumentNullException(nameof(nonce));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertingWebhookSecretHeaderValue" /> class.
        /// </summary>
        public AlertingWebhookSecretHeaderValue()
        {
        }

    }
}