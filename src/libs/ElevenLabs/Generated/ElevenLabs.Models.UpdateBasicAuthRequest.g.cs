
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateBasicAuthRequest
    {
        /// <summary>
        /// Default Value: basic_auth
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
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBasicAuthRequest" /> class.
        /// </summary>
        /// <param name="authType">
        /// Default Value: basic_auth
        /// </param>
        /// <param name="provider"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBasicAuthRequest(
            string? authType,
            string? provider,
            string? username,
            string? password)
        {
            this.AuthType = authType;
            this.Provider = provider;
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBasicAuthRequest" /> class.
        /// </summary>
        public UpdateBasicAuthRequest()
        {
        }

    }
}