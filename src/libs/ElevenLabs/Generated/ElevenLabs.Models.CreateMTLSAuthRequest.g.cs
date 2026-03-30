
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request model for creating mTLS auth connections.
    /// </summary>
    public sealed partial class CreateMTLSAuthRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: mtls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_certificate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientCertificate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ca_certificate")]
        public string? CaCertificate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_passphrase")]
        public string? KeyPassphrase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMTLSAuthRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="provider"></param>
        /// <param name="clientCertificate"></param>
        /// <param name="clientKey"></param>
        /// <param name="authType">
        /// Default Value: mtls
        /// </param>
        /// <param name="caCertificate"></param>
        /// <param name="keyPassphrase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMTLSAuthRequest(
            string name,
            string provider,
            string clientCertificate,
            string clientKey,
            string? authType,
            string? caCertificate,
            string? keyPassphrase)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthType = authType;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ClientCertificate = clientCertificate ?? throw new global::System.ArgumentNullException(nameof(clientCertificate));
            this.ClientKey = clientKey ?? throw new global::System.ArgumentNullException(nameof(clientKey));
            this.CaCertificate = caCertificate;
            this.KeyPassphrase = keyPassphrase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMTLSAuthRequest" /> class.
        /// </summary>
        public CreateMTLSAuthRequest()
        {
        }
    }
}