
#nullable enable
namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    public sealed partial class TextToDialogueMultiContextRealtimeClient
    {
        /// <summary>Deserializes a finalAudioForTurnMulti message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti DeserializeFinalAudioForTurnMultiMessage(string json) =>
            (global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_9DA77C6C6A48ACBB.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}