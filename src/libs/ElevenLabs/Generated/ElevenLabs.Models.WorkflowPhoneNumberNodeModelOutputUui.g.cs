
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// User-to-User Information (RFC 7433) to attach to SIP REFER transfers. Carries call context such as CRM identifiers or escalation reason across the transfer boundary.
    /// </summary>
    public sealed partial class WorkflowPhoneNumberNodeModelOutputUui
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}