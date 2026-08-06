
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Why this language failed; null unless `status` is 'failed', and also null for the few languages that failed before failure reporting was introduced. A code of 'project_failed' means the parent project failed, so read the project for the underlying cause.
    /// </summary>
    public sealed partial class DubbingLanguageResponseError
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}