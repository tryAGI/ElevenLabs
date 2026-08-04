
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// BCP-47 language tag of the source media; must be a language the transcription model supports. Any region or script subtag is ignored, since transcription is per-language. Omit to auto-detect.
    /// </summary>
    public sealed partial class BodyCreateDubbingProjectV1DubbingProjectPostSourceLanguage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}