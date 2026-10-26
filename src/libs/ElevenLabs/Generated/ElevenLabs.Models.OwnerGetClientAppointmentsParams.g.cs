
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Appointments with the booking channel, internal notes and intake answers.
    /// </summary>
    public sealed partial class OwnerGetClientAppointmentsParams
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_cancelled")]
        public bool? IncludeCancelled { get; set; }

        /// <summary>
        /// Default Value: owner_get_client_appointments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerGetClientAppointmentsParams" /> class.
        /// </summary>
        /// <param name="includeCancelled">
        /// Default Value: false
        /// </param>
        /// <param name="smbToolType">
        /// Default Value: owner_get_client_appointments
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OwnerGetClientAppointmentsParams(
            bool? includeCancelled,
            string? smbToolType)
        {
            this.IncludeCancelled = includeCancelled;
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerGetClientAppointmentsParams" /> class.
        /// </summary>
        public OwnerGetClientAppointmentsParams()
        {
        }

    }
}