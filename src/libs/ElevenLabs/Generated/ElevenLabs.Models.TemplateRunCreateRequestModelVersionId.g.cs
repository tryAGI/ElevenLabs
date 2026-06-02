
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Optional content snapshot ``version_id`` to execute. Omit to use the live template in the owning workspace, or the latest approved snapshot for anonymous / cross-workspace access.
    /// </summary>
    public sealed partial class TemplateRunCreateRequestModelVersionId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}