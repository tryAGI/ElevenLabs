
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Signed output URLs; null until the target has produced an output (present once 'completed', and kept while 'stale' -- compare `output_revision` against `revision` to tell whether the output is up to date).
    /// </summary>
    public sealed partial class LanguageResponseOutputs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}