
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A low-resolution waveform of the generated song, for showing a preview of it. Holds 4 values per second of audio, from -1000 to 1000. Stereo is mixed down to a single channel. Only present if `with_waveform_visual` was True in the request body.
    /// </summary>
    public sealed partial class DetailedMusicResponseWaveformVisual
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}