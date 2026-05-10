
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request model for updating MCP Server approval mode.
    /// </summary>
    public sealed partial class MCPApprovalPolicyUpdateRequestModel
    {
        /// <summary>
        /// The approval mode to set for the MCP server<br/>
        /// Default Value: require_approval_all
        /// </summary>
        /// <default>global::ElevenLabs.MCPApprovalPolicy.RequireApprovalAll</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MCPApprovalPolicyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.MCPApprovalPolicy ApprovalPolicy { get; set; } = global::ElevenLabs.MCPApprovalPolicy.RequireApprovalAll;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovalPolicyUpdateRequestModel" /> class.
        /// </summary>
        /// <param name="approvalPolicy">
        /// The approval mode to set for the MCP server<br/>
        /// Default Value: require_approval_all
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPApprovalPolicyUpdateRequestModel(
            global::ElevenLabs.MCPApprovalPolicy approvalPolicy)
        {
            this.ApprovalPolicy = approvalPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovalPolicyUpdateRequestModel" /> class.
        /// </summary>
        public MCPApprovalPolicyUpdateRequestModel()
        {
        }

    }
}