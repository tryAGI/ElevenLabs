
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Additional JWT header parameters (e.g. x5t). 'alg' and 'kid' are set from algorithm and key_id.
    /// </summary>
    public sealed partial class PrivateKeyJWTResponseExtraHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}