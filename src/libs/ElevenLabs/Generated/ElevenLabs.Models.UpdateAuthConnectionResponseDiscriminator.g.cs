
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAuthConnectionResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.UpdateAuthConnectionResponseDiscriminatorAuthTypeJsonConverter))]
        public global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType? AuthType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthConnectionResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="authType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAuthConnectionResponseDiscriminator(
            global::ElevenLabs.UpdateAuthConnectionResponseDiscriminatorAuthType? authType)
        {
            this.AuthType = authType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAuthConnectionResponseDiscriminator" /> class.
        /// </summary>
        public UpdateAuthConnectionResponseDiscriminator()
        {
        }

    }
}