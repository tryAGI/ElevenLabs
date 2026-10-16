
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Update an existing staff member's information.
    /// </summary>
    public sealed partial class UpdateStaffParams
    {
        /// <summary>
        /// Default Value: update_staff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Whether to offer a working_hours timezone, set from the workspace's enable_per_resource_timezones. While that is off every staff member uses the workspace timezone, so the key is not offered.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_resource_timezones")]
        public bool? PerResourceTimezones { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStaffParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: update_staff
        /// </param>
        /// <param name="perResourceTimezones">
        /// Whether to offer a working_hours timezone, set from the workspace's enable_per_resource_timezones. While that is off every staff member uses the workspace timezone, so the key is not offered.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateStaffParams(
            string? smbToolType,
            bool? perResourceTimezones)
        {
            this.SmbToolType = smbToolType;
            this.PerResourceTimezones = perResourceTimezones;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateStaffParams" /> class.
        /// </summary>
        public UpdateStaffParams()
        {
        }

    }
}