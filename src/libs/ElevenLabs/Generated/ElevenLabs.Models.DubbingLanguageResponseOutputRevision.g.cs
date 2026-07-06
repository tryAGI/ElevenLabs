
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The `revision` the current dubbed output was generated from; equal to `revision` when up to date, less than it when 'stale'. Null until a generation has completed.
    /// </summary>
    public sealed partial class DubbingLanguageResponseOutputRevision
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}