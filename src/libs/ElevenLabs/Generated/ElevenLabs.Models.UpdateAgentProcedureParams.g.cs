
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateAgentProcedureParams
    {
        /// <summary>
        /// Default Value: update_agent_procedure
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentProcedureParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: update_agent_procedure
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentProcedureParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentProcedureParams" /> class.
        /// </summary>
        public UpdateAgentProcedureParams()
        {
        }

    }
}