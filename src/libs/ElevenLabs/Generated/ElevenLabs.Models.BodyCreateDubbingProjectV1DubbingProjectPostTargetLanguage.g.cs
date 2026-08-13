
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Optional shortcut: also create a language target in this BCP-47 language, queued to start once the project is ready. Must be a language the dubbing model supports, and a region-qualified tag must be one of the supported dialects.
    /// </summary>
    public sealed partial class BodyCreateDubbingProjectV1DubbingProjectPostTargetLanguage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}