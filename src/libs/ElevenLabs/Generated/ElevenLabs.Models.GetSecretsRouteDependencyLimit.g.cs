
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Maximum number of dependent resources (tools, agents, phone numbers) to return per secret. Can not exceed 100.
    /// </summary>
    public sealed partial class GetSecretsRouteDependencyLimit
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}