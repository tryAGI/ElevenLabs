
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request model for creating Basic Auth connections - inherits common settings and includes sensitive fields
    /// </summary>
    public sealed partial class CreateBasicAuthRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: basic_auth
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
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Password { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBasicAuthRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="authType">
        /// Default Value: basic_auth
        /// </param>
        /// <param name="provider"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBasicAuthRequest(
            string name,
            string provider,
            string username,
            string password,
            string? authType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Password = password ?? throw new global::System.ArgumentNullException(nameof(password));
            this.AuthType = authType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBasicAuthRequest" /> class.
        /// </summary>
        public CreateBasicAuthRequest()
        {
        }
    }
}