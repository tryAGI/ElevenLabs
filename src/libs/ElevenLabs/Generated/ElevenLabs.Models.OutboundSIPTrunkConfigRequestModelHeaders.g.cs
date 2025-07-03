
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// SIP X-* headers for INVITE request. These headers are sent as-is and may help identify this call.
    /// </summary>
    public sealed partial class OutboundSIPTrunkConfigRequestModelHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}