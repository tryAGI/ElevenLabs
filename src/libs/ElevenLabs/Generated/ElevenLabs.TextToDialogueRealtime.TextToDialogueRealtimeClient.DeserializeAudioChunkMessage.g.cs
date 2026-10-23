
#nullable enable
namespace ElevenLabs.TextToDialogueRealtime
{
    public sealed partial class TextToDialogueRealtimeClient
    {
        /// <summary>Deserializes a audioChunk message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk DeserializeAudioChunkMessage(string json) =>
            (global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_72832701EE7C753A.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}