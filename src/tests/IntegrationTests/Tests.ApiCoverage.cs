using System.Net;
using System.Text;

namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void FlowsAndAgentWorkflows_ExposeCurrentApiModels()
    {
        GetSpeechHistorySource2.Flows.ToValueString().Should().Be("Flows");
        PermissionType.Flows.ToValueString().Should().Be("flows");
        WorkspaceGroupPermission.Flows.ToValueString().Should().Be("flows");

        typeof(BodyCreateAgentV1ConvaiAgentsCreatePost)
            .GetProperty(nameof(BodyCreateAgentV1ConvaiAgentsCreatePost.Workflow))!
            .PropertyType.Should().Be(typeof(AgentWorkflowRequestModel));
        typeof(BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch)
            .GetProperty(nameof(BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch.Workflow))!
            .PropertyType.Should().Be(typeof(AgentWorkflowRequestModel));

        typeof(AgentTransferOpPush).Should().NotBeNull();
        typeof(AgentTransferOpPop).Should().NotBeNull();
        typeof(AgentTransferOpReplace).Should().NotBeNull();
        typeof(RunSubagentToolConfigInput).Should().NotBeNull();
    }

    [TestMethod]
    public async Task AgentKnowledgeBaseRagQuery_SendsExpectedRequest()
    {
        using var httpClient = new HttpClient(new ApiCoverageHttpMessageHandler(async (request, cancellationToken) =>
        {
            request.Method.Should().Be(HttpMethod.Post);
            request.RequestUri.Should().NotBeNull();
            request.RequestUri!.PathAndQuery.Should().Be(
                "/v1/convai/agents/agent_123/knowledge-base/rag-query?branch_id=branch_456");
            request.Headers.GetValues("xi-api-key").Should().Contain(TestApiKey);

            var body = await request.Content!.ReadAsStringAsync(cancellationToken);
            body.Should().Contain("\"query\":\"How do I reset my password?\"");

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(
                    """{"retrieval_query":"How do I reset my password?","chunks":[]}""",
                    Encoding.UTF8,
                    "application/json"),
            };
        }))
        {
            BaseAddress = new Uri("https://api.elevenlabs.io"),
        };

        using var client = new ElevenLabsClient(TestApiKey, httpClient, disposeHttpClient: false);

        var response = await client.AgentsPlatform.QueryKnowledgeBaseRagAsync(
            agentId: "agent_123",
            query: "How do I reset my password?",
            branchId: "branch_456");

        response.RetrievalQuery.Should().Be("How do I reset my password?");
        response.Chunks.Should().BeEmpty();
    }

    private sealed class ApiCoverageHttpMessageHandler(
        Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> responder) : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken) => responder(request, cancellationToken);
    }
}
