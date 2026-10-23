
#nullable enable

namespace ElevenLabs.TextToDialogueRealtime
{
    public sealed partial class TextToDialogueRealtimeClient
    {
        /// <summary>
        /// Send dialogue text or a control message.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendClientMessageAsync(
            global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketClientMessage message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_10CAB764DC3294EF.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketClientMessage)));

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}