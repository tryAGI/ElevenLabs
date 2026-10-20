
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateClientSecretRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::ElevenLabs.OpenAISessionConfigInput? Session { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::ElevenLabs.ExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientSecretRequest" /> class.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="expiresAfter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClientSecretRequest(
            global::ElevenLabs.OpenAISessionConfigInput? session,
            global::ElevenLabs.ExpiresAfter? expiresAfter)
        {
            this.Session = session;
            this.ExpiresAfter = expiresAfter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClientSecretRequest" /> class.
        /// </summary>
        public CreateClientSecretRequest()
        {
        }

    }
}