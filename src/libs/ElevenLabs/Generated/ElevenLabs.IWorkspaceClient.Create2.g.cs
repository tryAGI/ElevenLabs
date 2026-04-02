#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Create Workspace Auth Connection<br/>
        /// Create a new OAuth2 auth connection for the workspace
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAuthConnectionResponse> Create2Async(

            global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace Auth Connection<br/>
        /// Create a new OAuth2 auth connection for the workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAuthConnectionResponse> Create2Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}