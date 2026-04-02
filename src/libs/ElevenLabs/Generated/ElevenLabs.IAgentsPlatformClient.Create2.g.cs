#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Post Agent Avatar<br/>
        /// Sets the avatar for an agent displayed in the widget
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PostAgentAvatarResponseModel> Create2Async(
            string agentId,

            global::ElevenLabs.BodyPostAgentAvatarV1ConvaiAgentsAgentIdAvatarPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post Agent Avatar<br/>
        /// Sets the avatar for an agent displayed in the widget
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="avatarFile">
        /// An image file to be used as the agent's avatar.
        /// </param>
        /// <param name="avatarFilename">
        /// An image file to be used as the agent's avatar.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.PostAgentAvatarResponseModel> Create2Async(
            string agentId,
            byte[] avatarFile,
            string avatarFilename,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}