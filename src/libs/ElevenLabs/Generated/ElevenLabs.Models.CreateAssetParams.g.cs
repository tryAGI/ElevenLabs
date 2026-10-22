
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAssetParams
    {
        /// <summary>
        /// Default Value: create_asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Whether to offer an available_hours timezone, set from the workspace's enable_per_resource_timezones.<br/>
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
        /// Initializes a new instance of the <see cref="CreateAssetParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: create_asset
        /// </param>
        /// <param name="perResourceTimezones">
        /// Whether to offer an available_hours timezone, set from the workspace's enable_per_resource_timezones.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAssetParams(
            string? smbToolType,
            bool? perResourceTimezones)
        {
            this.SmbToolType = smbToolType;
            this.PerResourceTimezones = perResourceTimezones;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssetParams" /> class.
        /// </summary>
        public CreateAssetParams()
        {
        }

    }
}