
#nullable enable

namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    public sealed partial class TextToDialogueWebsocketAudioChunkMulti
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