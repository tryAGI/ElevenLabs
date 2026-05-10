
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAuthConnectionsResponseAuthConnectionDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthTypeJsonConverter))]
        public global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType? AuthType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuthConnectionsResponseAuthConnectionDiscriminator" /> class.
        /// </summary>
        /// <param name="authType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAuthConnectionsResponseAuthConnectionDiscriminator(
            global::ElevenLabs.ListAuthConnectionsResponseAuthConnectionDiscriminatorAuthType? authType)
        {
            this.AuthType = authType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAuthConnectionsResponseAuthConnectionDiscriminator" /> class.
        /// </summary>
        public ListAuthConnectionsResponseAuthConnectionDiscriminator()
        {
        }

    }
}