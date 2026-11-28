
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Your own key-value pairs for the workspace, such as your customer or contract id. Up to 20 keys of up to 40 characters, without `.` or `$`, and values of up to 500 characters. Not shown to the workspace's members.<br/>
    /// Default Value: {}
    /// </summary>
    public sealed partial class ReceptionProvisionResellerWorkspaceRequestMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}