
#nullable enable
namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    public sealed partial class TextToDialogueMultiContextRealtimeClient
    {
        /// <summary>Deserializes a error message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError DeserializeErrorMessage(string json) =>
            (global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_77B5432CB70F5AEE.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}