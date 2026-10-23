
#nullable enable
namespace ElevenLabs.TextToDialogueRealtime
{
    public sealed partial class TextToDialogueRealtimeClient
    {
        /// <summary>Deserializes a finalAudioForTurn message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn DeserializeFinalAudioForTurnMessage(string json) =>
            (global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_E8E2FBCB8E3ADB2F.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}