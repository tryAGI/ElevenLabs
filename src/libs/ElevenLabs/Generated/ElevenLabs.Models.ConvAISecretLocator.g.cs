
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Used to reference a secret from the agent's secret store.
    /// </summary>
    public sealed partial class ConvAISecretLocator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAISecretLocator" /> class.
        /// </summary>
        /// <param name="secretId"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ConvAISecretLocator(
            string secretId)
        {
            this.SecretId = secretId ?? throw new global::System.ArgumentNullException(nameof(secretId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvAISecretLocator" /> class.
        /// </summary>
        public ConvAISecretLocator()
        {
        }
    }
}