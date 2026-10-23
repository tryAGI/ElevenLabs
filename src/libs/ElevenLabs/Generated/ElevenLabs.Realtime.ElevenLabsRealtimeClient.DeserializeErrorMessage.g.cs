
#nullable enable
namespace ElevenLabs.Realtime
{
    public sealed partial class ElevenLabsRealtimeClient
    {
        /// <summary>Deserializes a error message using its own metadata graph.</summary>
        /// <param name="json">The received JSON message.</param>
        /// <returns>The typed message.</returns>
        public global::ElevenLabs.Realtime.ErrorPayload DeserializeErrorMessage(string json) =>
            (global::ElevenLabs.Realtime.ErrorPayload)(global::System.Text.Json.JsonSerializer.Deserialize(json,
                (JsonSerializerContextProvider?.Value ?? global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_20860E292D2AFFC4.Default).Options.GetTypeInfo(typeof(global::ElevenLabs.Realtime.ErrorPayload)))
                ?? throw new global::System.Text.Json.JsonException("The received message was null."));
    }
}