
#nullable enable

namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    public sealed partial class TextToDialogueMultiContextRealtimeClient
    {
        /// <summary>
        /// Send dialogue text or a control message for one or all contexts.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendClientMessageMultiAsync(
            global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketClientMessageMulti message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketClientMessageMulti), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}