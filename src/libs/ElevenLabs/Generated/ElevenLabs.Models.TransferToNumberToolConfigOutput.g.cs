
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToNumberToolConfigOutput
    {
        /// <summary>
        /// Default Value: transfer_to_number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferToNumberToolConfigOutputSystemToolTypeJsonConverter))]
        public global::ElevenLabs.TransferToNumberToolConfigOutputSystemToolType? SystemToolType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumberTransfer> Transfers { get; set; }

        /// <summary>
        /// Whether to play a message to the client while they wait for transfer. Defaults to true for backward compatibility.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_client_message")]
        public bool? EnableClientMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberToolConfigOutput" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: transfer_to_number
        /// </param>
        /// <param name="transfers"></param>
        /// <param name="enableClientMessage">
        /// Whether to play a message to the client while they wait for transfer. Defaults to true for backward compatibility.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferToNumberToolConfigOutput(
            global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumberTransfer> transfers,
            global::ElevenLabs.TransferToNumberToolConfigOutputSystemToolType? systemToolType,
            bool? enableClientMessage)
        {
            this.Transfers = transfers ?? throw new global::System.ArgumentNullException(nameof(transfers));
            this.SystemToolType = systemToolType;
            this.EnableClientMessage = enableClientMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberToolConfigOutput" /> class.
        /// </summary>
        public TransferToNumberToolConfigOutput()
        {
        }
    }
}