
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Finalize the onboarding interview: create a text knowledge source and mark done.
    /// </summary>
    public sealed partial class SubmitBusinessInfoParams
    {
        /// <summary>
        /// Default Value: submit_business_info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBusinessInfoParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: submit_business_info
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubmitBusinessInfoParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubmitBusinessInfoParams" /> class.
        /// </summary>
        public SubmitBusinessInfoParams()
        {
        }

    }
}