
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAuthConnectionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_connections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.AuthConnectionsItem> AuthConnections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuthConnectionsResponse" /> class.
        /// </summary>
        /// <param name="authConnections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAuthConnectionsResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.AuthConnectionsItem> authConnections)
        {
            this.AuthConnections = authConnections ?? throw new global::System.ArgumentNullException(nameof(authConnections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuthConnectionsResponse" /> class.
        /// </summary>
        public ListAuthConnectionsResponse()
        {
        }

    }
}