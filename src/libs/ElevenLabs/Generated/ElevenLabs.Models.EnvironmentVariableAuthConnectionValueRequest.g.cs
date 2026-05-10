
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentVariableAuthConnectionValueRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthConnectionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariableAuthConnectionValueRequest" /> class.
        /// </summary>
        /// <param name="authConnectionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentVariableAuthConnectionValueRequest(
            string authConnectionId)
        {
            this.AuthConnectionId = authConnectionId ?? throw new global::System.ArgumentNullException(nameof(authConnectionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentVariableAuthConnectionValueRequest" /> class.
        /// </summary>
        public EnvironmentVariableAuthConnectionValueRequest()
        {
        }

    }
}