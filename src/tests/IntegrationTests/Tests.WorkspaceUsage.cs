using System.Net;
using System.Text;
using System.Text.Json;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task WorkspaceUsage_SendsUnixMilliseconds()
    {
        const long startTime = 1_785_542_400_000;
        const long endTime = 1_788_216_337_000;

        using var httpClient = new HttpClient(new WorkspaceUsageHttpMessageHandler(
            async (request, cancellationToken) =>
            {
                request.Method.Should().Be(HttpMethod.Post);
                request.RequestUri.Should().NotBeNull();
                request.RequestUri!.PathAndQuery.Should().Be(
                    "/v1/workspace/analytics/query/usage-by-product-over-time");
                request.Headers.GetValues("xi-api-key").Should().Contain(TestApiKey);

                var body = await request.Content!.ReadAsStringAsync(cancellationToken);
                using var document = JsonDocument.Parse(body);
                document.RootElement.GetProperty("start_time").GetInt64().Should().Be(startTime);
                document.RootElement.GetProperty("end_time").GetInt64().Should().Be(endTime);
                document.RootElement.GetProperty("interval_seconds").GetInt32().Should().Be(86_400);

                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(
                        """
                        {
                          "columns": ["timestamp", "product_type", "credits_used"],
                          "column_types": ["DateTime", "String", "Float"],
                          "rows": [],
                          "column_units": ["s", "", "credits"]
                        }
                        """,
                        Encoding.UTF8,
                        "application/json"),
                };
            }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };
        using var client = new ElevenLabsClient(TestApiKey, httpClient, disposeHttpClient: false);

        var response = await client.AccessAll.GetUsageByProductOverTimeAsync(
            startTime,
            endTime,
            intervalSeconds: 86_400);

        response.Rows.Should().BeEmpty();
    }

    private sealed class WorkspaceUsageHttpMessageHandler(
        Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> responder) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken) => responder(request, cancellationToken);
    }
}
