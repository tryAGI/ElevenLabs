
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// npm dependencies as a package-name → version map (e.g. {"lodash": "^4.17.21"})
    /// </summary>
    public sealed partial class CodeToolConfigInputDependencies
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}