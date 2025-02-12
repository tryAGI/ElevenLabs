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
        /// The id of an agent. This is returned on agent creation.
        /// </param>
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
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentResponseModel> EditConvaiAgentsByAgentIdAsync(
            string agentId,
            global::ElevenLabs.BodyPatchesAnAgentSettingsV1ConvaiAgentsAgentIdPatch request,
            bool? useToolIds = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Patches An Agent Settings<br/>
        /// Patches an Agent settings
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
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
        /// <param name="secrets">
        /// A list of secrets for the agent. Can be used to add new secrets or update and delete the existing ones
        /// </param>
        /// <param name="name">
        /// A name to make the agent easier to find
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetAgentResponseModel> EditConvaiAgentsByAgentIdAsync(
            string agentId,
            bool? useToolIds = default,
            string? xiApiKey = default,
            object? conversationConfig = default,
            object? platformSettings = default,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.ConvAINewSecretConfig, global::ElevenLabs.ConvAIStoredSecretConfig>>? secrets = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}