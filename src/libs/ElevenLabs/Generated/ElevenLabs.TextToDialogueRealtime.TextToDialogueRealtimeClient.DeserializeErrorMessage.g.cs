
#nullable enable
namespace ElevenLabs.TextToDialogueRealtime
{
    public sealed partial class TextToDialogueRealtimeClient
    {
        /// <summary>Deserializes a error message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError DeserializeErrorMessage(string json) =>
            (global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_91194FEA58A0A8A9.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}