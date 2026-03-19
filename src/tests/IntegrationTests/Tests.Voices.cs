using System.Net;
using System.Net.Http;
using System.Text;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task GetVoices_AllowsInt64UnixMillisecondsInFineTuningResponse()
    {
        // The live voices payload returns millisecond epoch values that exceed Int32.
        const string responseBody = """
            {
              "voices": [
                {
                  "voice_id": "voice-id",
                  "name": "Voice",
                  "category": "premade",
                  "fine_tuning": {
                    "is_allowed_to_fine_tune": true,
                    "state": {},
                    "verification_failures": [],
                    "verification_attempts_count": 0,
                    "manual_verification_requested": false,
                    "next_max_verification_attempts_reset_unix_ms": 1700000000000
                  },
                  "labels": {},
                  "available_for_tiers": [],
                  "high_quality_base_model_ids": []
                }
              ]
            }
            """;

        using var httpClient = new HttpClient(new VoicesStubHttpMessageHandler(
            static _ => new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(responseBody, Encoding.UTF8, "application/json"),
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        var client = new VoicesClient(httpClient, disposeHttpClient: false);

        GetVoicesResponseModel response = await client.GetVoicesAsync();

        response.Voices.Should().ContainSingle();
        response.Voices[0].FineTuning.Should().NotBeNull();
        response.Voices[0].FineTuning!.NextMaxVerificationAttemptsResetUnixMs.Should().Be(1700000000000L);
    }

    private sealed class VoicesStubHttpMessageHandler(Func<HttpRequestMessage, HttpResponseMessage> responder) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            return Task.FromResult(responder(request));
        }
    }
}
