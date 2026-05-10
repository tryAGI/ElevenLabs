
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Additional custom claims to include in the JWT
    /// </summary>
    public sealed partial class CreateOAuth2JWTRequestExtraParams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}