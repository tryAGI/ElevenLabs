#nullable enable

namespace ElevenLabs
{
    public partial interface ISingleUseTokenClient
    {
        /// <summary>
        /// Create Single Use Token<br/>
        /// Generate a time limited single-use token with embedded authentication for frontend clients.
        /// </summary>
        /// <param name="tokenType"></param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SingleUseTokenResponseModel> CreateSingleUseTokenByTokenTypeAsync(
            global::ElevenLabs.SingleUseTokenType tokenType,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}