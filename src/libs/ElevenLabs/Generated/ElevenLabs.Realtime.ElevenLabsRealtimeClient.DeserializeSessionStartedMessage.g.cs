
#nullable enable
namespace ElevenLabs.Realtime
{
    public sealed partial class ElevenLabsRealtimeClient
    {
        /// <summary>Deserializes a sessionStarted message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.Realtime.SessionStartedPayload DeserializeSessionStartedMessage(string json) =>
            (global::ElevenLabs.Realtime.SessionStartedPayload)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_CC96F45A1184CE4D.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.Realtime.SessionStartedPayload)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}