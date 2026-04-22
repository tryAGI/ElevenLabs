
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Look up an appointment by the booking confirmation number the caller quotes.<br/>
    /// The confirmation number is the 8-character code shown on the booking<br/>
    /// confirmation page (e.g. ``#01ABCDEF``). Callers may read it back with or<br/>
    /// without the leading ``#`` and with varied spacing; the tool normalizes<br/>
    /// the input and does a prefix match on the stored calendar item id.
    /// </summary>
    public sealed partial class GetAppointmentByConfirmationNumberParams
    {
        /// <summary>
        /// Default Value: get_appointment_by_confirmation_number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAppointmentByConfirmationNumberParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: get_appointment_by_confirmation_number
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAppointmentByConfirmationNumberParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAppointmentByConfirmationNumberParams" /> class.
        /// </summary>
        public GetAppointmentByConfirmationNumberParams()
        {
        }
    }
}