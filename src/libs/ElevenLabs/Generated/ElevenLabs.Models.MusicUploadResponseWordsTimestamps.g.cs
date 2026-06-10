
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Word-level timestamps transcribed from the uploaded song. Only present if `with_timestamps` was True in the request body
    /// </summary>
    public sealed partial class MusicUploadResponseWordsTimestamps
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}