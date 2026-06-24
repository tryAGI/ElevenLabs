
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateBearerAuthRequest
    {
        /// <summary>
        /// Default Value: bearer_auth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBearerAuthRequest" /> class.
        /// </summary>
        /// <param name="authType">
        /// Default Value: bearer_auth
        /// </param>
        /// <param name="provider"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBearerAuthRequest(
            string? authType,
            string? provider,
            string? token)
        {
            this.AuthType = authType;
            this.Provider = provider;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBearerAuthRequest" /> class.
        /// </summary>
        public UpdateBearerAuthRequest()
        {
        }

    }
}