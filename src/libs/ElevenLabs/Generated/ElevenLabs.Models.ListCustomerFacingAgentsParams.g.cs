
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// List every customer-facing agent on the workspace.<br/>
    /// The assistant uses this whenever it needs to act on a specific customer-facing<br/>
    /// agent (rules, config edits, etc.) so it can pick the right ``agent_id`` to pass<br/>
    /// to mutating tools. Mirrors the ``list_services`` / ``list_clients``<br/>
    /// pattern: read once, then mutate by id.
    /// </summary>
    public sealed partial class ListCustomerFacingAgentsParams
    {
        /// <summary>
        /// Default Value: list_customer_facing_agents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomerFacingAgentsParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: list_customer_facing_agents
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCustomerFacingAgentsParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCustomerFacingAgentsParams" /> class.
        /// </summary>
        public ListCustomerFacingAgentsParams()
        {
        }

    }
}