
#nullable enable

namespace ElevenLabs.TextToDialogueRealtime
{
    public sealed partial class TextToDialogueWebsocketAudioChunk
    {
        /// <summary>
        /// Gets the decoded bytes for <see cref="Audio" />.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonIgnore]
        public global::System.ReadOnlyMemory<byte> AudioBytes => Audio is null
            ? default
            : global::System.Convert.FromBase64String(Audio);
    }
}