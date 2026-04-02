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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SingleUseTokenResponseModel> CreateAsync(
            global::ElevenLabs.SingleUseTokenType tokenType,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}