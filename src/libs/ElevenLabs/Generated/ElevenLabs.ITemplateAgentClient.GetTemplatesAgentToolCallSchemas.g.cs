#nullable enable

namespace ElevenLabs
{
    public partial interface ITemplateAgentClient
    {
        /// <summary>
        /// Flow Agent Tool-Call Schemas<br/>
        /// Anchor every flows-agent tool input model in the OpenAPI schema.<br/>
        /// The frontend imports the generated TypeScript shapes from `@/api/xiSchemas`<br/>
        /// to render typed approval details for each tool call. The endpoint itself<br/>
        /// intentionally returns an empty payload — only the response schema matters.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.FlowsAgentToolCallSchemas> GetTemplatesAgentToolCallSchemasAsync(
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}