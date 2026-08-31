
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Why the project failed; null unless `status` is `failed`. Also null for the few projects that failed before failure reporting was introduced.
    /// </summary>
    public sealed partial class DubbingProjectResponseError
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}