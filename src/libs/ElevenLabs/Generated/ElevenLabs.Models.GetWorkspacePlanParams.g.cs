
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Read the workspace's current Reception plan and its hard limits.<br/>
    /// Call this before answering any plan, pricing, trial, or limit question so<br/>
    /// the assistant stops guessing (e.g. telling a paying owner they're on the<br/>
    /// trial, or hallucinating concurrent-call / receptionist / voice-cloning<br/>
    /// caps). The tool exposes only the shape of the plan — a display name;<br/>
    /// whether it's trial / paid / untiered; the entitlement caps (max<br/>
    /// receptionists, phone numbers, active locations, team members, concurrent<br/>
    /// calls, voice-cloning quota) alongside the current counts; and whether<br/>
    /// there's a payment issue. It deliberately does NOT return list prices or<br/>
    /// dollar amounts, nor the trial / renewal end date: pricing and renewal<br/>
    /// dates are a product decision and live in the Settings &gt; Billing plan<br/>
    /// picker.
    /// </summary>
    public sealed partial class GetWorkspacePlanParams
    {
        /// <summary>
        /// Default Value: get_workspace_plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspacePlanParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: get_workspace_plan
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkspacePlanParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkspacePlanParams" /> class.
        /// </summary>
        public GetWorkspacePlanParams()
        {
        }

    }
}