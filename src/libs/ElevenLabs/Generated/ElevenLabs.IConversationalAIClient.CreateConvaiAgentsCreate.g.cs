#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Create Agent<br/>
        /// Create an agent from a config object
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentResponseModel> CreateConvaiAgentsCreateAsync(
            global::ElevenLabs.BodyCreateAgentV1ConvaiAgentsCreatePost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Agent<br/>
        /// Create an agent from a config object
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="conversationConfig"></param>
        /// <param name="platformSettings"></param>
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentResponseModel> CreateConvaiAgentsCreateAsync(
            global::ElevenLabs.ConversationalConfigAPIModelInput conversationConfig,
            string? xiApiKey = default,
            global::ElevenLabs.AgentPlatformSettingsRequestModel? platformSettings = default,
            object? workflow = default,
            string? name = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}