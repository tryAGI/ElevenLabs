
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Enterprise only. Optional JSON transcript to use instead of automatic transcription. When provided, source_language is required. Segments may include an optional external_id and an optional translation; if any segment includes a translation, target_language is required and every segment must include one (used to seed the target created via target_language).
    /// </summary>
    public sealed partial class BodyCreateDubbingProjectV1DubbingProjectPostTranscript
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}