
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Every location, inactive ones included, with every owner-editable field.
    /// </summary>
    public sealed partial class OwnerListLocationsParams
    {
        /// <summary>
        /// Default Value: owner_list_locations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerListLocationsParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: owner_list_locations
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OwnerListLocationsParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OwnerListLocationsParams" /> class.
        /// </summary>
        public OwnerListLocationsParams()
        {
        }

    }
}