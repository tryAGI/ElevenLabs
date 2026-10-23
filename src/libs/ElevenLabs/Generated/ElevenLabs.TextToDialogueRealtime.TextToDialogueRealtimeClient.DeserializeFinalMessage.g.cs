
#nullable enable
namespace ElevenLabs.TextToDialogueRealtime
{
    public sealed partial class TextToDialogueRealtimeClient
    {
        /// <summary>Deserializes a final message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal DeserializeFinalMessage(string json) =>
            (global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_48E34CF644C9AE5A.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}