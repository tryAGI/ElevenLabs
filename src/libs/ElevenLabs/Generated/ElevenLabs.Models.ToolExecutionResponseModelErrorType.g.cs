
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Error category (internal, customer_config, customer_auth, external_server, external_client, client_timeout, unknown)
    /// </summary>
    public sealed partial class ToolExecutionResponseModelErrorType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}