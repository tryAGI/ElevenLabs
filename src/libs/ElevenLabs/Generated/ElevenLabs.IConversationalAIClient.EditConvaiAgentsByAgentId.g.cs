#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Patches An Agent Settings<br/>
        /// Patches an Agent settings
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentResponseModel> EditConvaiAgentsByAgentIdAsync(
            string agentId,
            global::ElevenLabs.BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Patches An Agent Settings<br/>
        /// Patches an Agent settings
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="conversationConfig">
        /// Conversation configuration for an agent
        /// </param>
        /// <param name="platformSettings">
        /// Platform settings for the agent are all settings that aren't related to the conversation orchestration and content.
        /// </param>
        /// <param name="workflow">
        /// Workflow for the agent. This is used to define the flow of the conversation and how the agent interacts with tools.
        /// </param>
        /// <param name="name">
        /// A name to make the agent easier to find<br/>
        /// Example: My agent
        /// </param>
        /// <param name="tags">
        /// Tags to help classify and filter the agent<br/>
        /// Example: [Customer Support, Technical Help, Eleven]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentResponseModel> EditConvaiAgentsByAgentIdAsync(
            string agentId,
            string? xiApiKey = default,
            object? conversationConfig = default,
            object? platformSettings = default,
            object? workflow = default,
            string? name = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}