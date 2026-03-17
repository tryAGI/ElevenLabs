
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Filter to only return variables that have this environment. When specified, the values dict in the response will only contain this environment.
    /// </summary>
    public sealed partial class ListEnvironmentVariablesEnvironment
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}