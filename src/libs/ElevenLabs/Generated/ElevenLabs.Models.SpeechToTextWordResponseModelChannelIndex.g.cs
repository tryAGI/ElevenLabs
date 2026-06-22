
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The channel this word was spoken on (for multichannel audio). Null for single-channel transcriptions.
    /// </summary>
    public sealed partial class SpeechToTextWordResponseModelChannelIndex
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}