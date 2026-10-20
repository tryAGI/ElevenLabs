
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ClientSecretResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::ElevenLabs.OpenAISessionConfigOutput? Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSecretResponse" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="expiresAt"></param>
        /// <param name="session"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientSecretResponse(
            string value,
            int expiresAt,
            global::ElevenLabs.OpenAISessionConfigOutput? session)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.ExpiresAt = expiresAt;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientSecretResponse" /> class.
        /// </summary>
        public ClientSecretResponse()
        {
        }

    }
}