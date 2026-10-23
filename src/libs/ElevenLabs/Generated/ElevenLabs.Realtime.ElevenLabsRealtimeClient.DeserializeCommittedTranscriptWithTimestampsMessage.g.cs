
#nullable enable
namespace ElevenLabs.Realtime
{
    public sealed partial class ElevenLabsRealtimeClient
    {
        /// <summary>Deserializes a committedTranscriptWithTimestamps message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload DeserializeCommittedTranscriptWithTimestampsMessage(string json) =>
            (global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_1791A6590553071C.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}