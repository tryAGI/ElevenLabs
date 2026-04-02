#nullable enable

namespace ElevenLabs
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// List Phone Numbers<br/>
        /// Retrieve all Phone Numbers
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ElevenLabs.ListPhoneNumbersRouteResponseItem>> List4Async(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}