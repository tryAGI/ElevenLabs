
#nullable enable
namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    public sealed partial class TextToDialogueMultiContextRealtimeClient
    {
        /// <summary>Deserializes a finalMulti message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti DeserializeFinalMultiMessage(string json) =>
            (global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_F63A337AAC7AC0DB.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}