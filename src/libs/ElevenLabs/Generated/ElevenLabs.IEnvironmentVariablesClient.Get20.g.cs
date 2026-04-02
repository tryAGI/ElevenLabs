#nullable enable

namespace ElevenLabs
{
    public partial interface IEnvironmentVariablesClient
    {
        /// <summary>
        /// Get Environment Variable<br/>
        /// Get a specific environment variable by ID
        /// </summary>
        /// <param name="envVarId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EnvironmentVariableResponse> Get20Async(
            string envVarId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}