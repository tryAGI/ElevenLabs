
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Values to replace. Set to null to remove an environment (except 'production').
    /// </summary>
    public sealed partial class UpdateEnvironmentVariableRequestValues
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}