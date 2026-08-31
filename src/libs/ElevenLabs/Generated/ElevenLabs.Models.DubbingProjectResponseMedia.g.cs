
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Source media metadata, populated once the source has been fetched and decoded (shortly after create, before the project is `ready`); null until then.
    /// </summary>
    public sealed partial class DubbingProjectResponseMedia
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}