#nullable enable

namespace ElevenLabs
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Create Agent<br/>
        /// Create an agent from a config object
        /// </summary>
        /// <param name="useToolIds">
        /// Use tool ids instead of tools specs from request payload.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentResponseModel> CreateConvaiAgentsCreateAsync(
            global::ElevenLabs.BodyCreateAgentV1ConvaiAgentsCreatePost request,
            bool? useToolIds = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Agent<br/>
        /// Create an agent from a config object
        /// </summary>
        /// <param name="useToolIds">
        /// Use tool ids instead of tools specs from request payload.<br/>
        /// Default Value: false
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
        /// <param name="name">
        /// A name to make the agent easier to find
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAgentResponseModel> CreateConvaiAgentsCreateAsync(
            global::ElevenLabs.ConversationalConfig conversationConfig,
            bool? useToolIds = default,
            string? xiApiKey = default,
            global::ElevenLabs.AgentPlatformSettingsRequestModel? platformSettings = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}