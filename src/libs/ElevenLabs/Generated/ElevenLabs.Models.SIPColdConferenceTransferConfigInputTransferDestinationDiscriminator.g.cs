
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SIPColdConferenceTransferConfigInputTransferDestinationDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorTypeJsonConverter))]
        public global::ElevenLabs.SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPColdConferenceTransferConfigInputTransferDestinationDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPColdConferenceTransferConfigInputTransferDestinationDiscriminator(
            global::ElevenLabs.SIPColdConferenceTransferConfigInputTransferDestinationDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPColdConferenceTransferConfigInputTransferDestinationDiscriminator" /> class.
        /// </summary>
        public SIPColdConferenceTransferConfigInputTransferDestinationDiscriminator()
        {
        }

    }
}