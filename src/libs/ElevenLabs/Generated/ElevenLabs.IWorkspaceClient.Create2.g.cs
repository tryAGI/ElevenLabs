#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Create Workspace Auth Connection<br/>
        /// Create a new OAuth2 auth connection for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAuthConnectionResponse> Create2Async(

            global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest> request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Workspace Auth Connection<br/>
        /// Create a new OAuth2 auth connection for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.CreateAuthConnectionResponse> Create2Async(
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}