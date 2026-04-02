#nullable enable

namespace ElevenLabs
{
    public partial interface IElevenLabsClient
    {
        /// <summary>
        /// Get User Subscription Info<br/>
        /// Gets extended information about the users subscription
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.ExtendedSubscriptionResponseModel> GetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}