#nullable enable

namespace ElevenLabs
{
    public partial interface IEnvironmentVariablesClient
    {
        /// <summary>
        /// Update Environment Variable<br/>
        /// Replace an environment variable's values. Use null to remove an environment (except production).
        /// </summary>
        /// <param name="envVarId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EnvironmentVariableResponse> Update14Async(
            string envVarId,

            global::ElevenLabs.UpdateEnvironmentVariableRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Environment Variable<br/>
        /// Replace an environment variable's values. Use null to remove an environment (except production).
        /// </summary>
        /// <param name="envVarId"></param>
        /// <param name="values">
        /// Values to replace. Set to null to remove an environment (except 'production').
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EnvironmentVariableResponse> Update14Async(
            string envVarId,
            object values,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}