#nullable enable

namespace ElevenLabs
{
    public partial interface IEnvironmentVariablesClient
    {
        /// <summary>
        /// Create Environment Variable<br/>
        /// Create a new environment variable for the workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EnvironmentVariableResponse> Create15Async(

            global::ElevenLabs.CreateEnvironmentVariableRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Environment Variable<br/>
        /// Create a new environment variable for the workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EnvironmentVariableResponse> Create15Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}