
#nullable enable
namespace ElevenLabs.Realtime
{
    public sealed partial class ElevenLabsRealtimeClient
    {
        /// <summary>Deserializes a committedTranscript message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.Realtime.CommittedTranscriptPayload DeserializeCommittedTranscriptMessage(string json) =>
            (global::ElevenLabs.Realtime.CommittedTranscriptPayload)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_8654C363EBB03B9F.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.Realtime.CommittedTranscriptPayload)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}