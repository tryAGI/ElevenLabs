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
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EnvironmentVariableResponse> Update13Async(
            string envVarId,

            global::ElevenLabs.UpdateEnvironmentVariableRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Environment Variable<br/>
        /// Replace an environment variable's values. Use null to remove an environment (except production).
        /// </summary>
        /// <param name="envVarId"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="values">
        /// Values to replace. Set to null to remove an environment (except 'production').
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EnvironmentVariableResponse> Update13Async(
            string envVarId,
            object values,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}