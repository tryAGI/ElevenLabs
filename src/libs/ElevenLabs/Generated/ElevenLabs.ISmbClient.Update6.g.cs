#nullable enable

namespace ElevenLabs
{
    public partial interface ISmbClient
    {
        /// <summary>
        /// Update Rule<br/>
        /// Replace an existing rule on the named receptionist. Send every field: an omitted `priority` resets to `strict`.
        /// </summary>
        /// <param name="agentId">
        /// ID of the receptionist. List them with `GET /v1/reception/customer-facing-agents`.
        /// </param>
        /// <param name="ruleId">
        /// ID of the rule. Returned when you add one, and listed in the receptionist's `config.agent_rules`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentRule> Update6Async(
            string agentId,
            string ruleId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionUpdateAgentRuleRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Rule<br/>
        /// Replace an existing rule on the named receptionist. Send every field: an omitted `priority` resets to `strict`.
        /// </summary>
        /// <param name="agentId">
        /// ID of the receptionist. List them with `GET /v1/reception/customer-facing-agents`.
        /// </param>
        /// <param name="ruleId">
        /// ID of the rule. Returned when you add one, and listed in the receptionist's `config.agent_rules`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AutoSDKHttpResponse<global::ElevenLabs.AgentRule>> Update6AsResponseAsync(
            string agentId,
            string ruleId,
            string xiWorkspaceId,

            global::ElevenLabs.ReceptionUpdateAgentRuleRequest request,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Rule<br/>
        /// Replace an existing rule on the named receptionist. Send every field: an omitted `priority` resets to `strict`.
        /// </summary>
        /// <param name="agentId">
        /// ID of the receptionist. List them with `GET /v1/reception/customer-facing-agents`.
        /// </param>
        /// <param name="ruleId">
        /// ID of the rule. Returned when you add one, and listed in the receptionist's `config.agent_rules`.
        /// </param>
        /// <param name="xiWorkspaceId">
        /// The customer workspace a reseller's API key acts on.
        /// </param>
        /// <param name="title">
        /// Title of the rule.
        /// </param>
        /// <param name="description">
        /// What the agent should do, in detail.
        /// </param>
        /// <param name="priority">
        /// strict: the agent must always follow the rule; suggestion: a guideline.<br/>
        /// Default Value: strict
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.AgentRule> Update6Async(
            string agentId,
            string ruleId,
            string xiWorkspaceId,
            string title,
            string description,
            global::ElevenLabs.RulePriority? priority = default,
            global::ElevenLabs.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}