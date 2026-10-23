
#nullable enable
namespace ElevenLabs.Realtime
{
    public sealed partial class ElevenLabsRealtimeClient
    {
        /// <summary>Deserializes a partialTranscript message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.Realtime.PartialTranscriptPayload DeserializePartialTranscriptMessage(string json) =>
            (global::ElevenLabs.Realtime.PartialTranscriptPayload)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_318982751006B693.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.Realtime.PartialTranscriptPayload)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}