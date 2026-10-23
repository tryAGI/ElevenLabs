
#nullable enable
namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    public sealed partial class TextToDialogueMultiContextRealtimeClient
    {
        /// <summary>Deserializes a audioChunkMulti message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti DeserializeAudioChunkMultiMessage(string json) =>
            (global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_88BC87CCE3F66452.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}