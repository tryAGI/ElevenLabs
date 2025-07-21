#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// List Dubs<br/>
        /// List the dubs you have access to.
        /// </summary>
        /// <param name="cursor">
        /// Used for fetching next page. Cursor is returned in the response.
        /// </param>
        /// <param name="pageSize">
        /// How many dubs to return at maximum. Can not exceed 200, defaults to 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="dubbingStatus">
        /// What state the dub is currently in.
        /// </param>
        /// <param name="filterByCreator">
        /// Filters who created the resources being listed, whether it was the user running the request or someone else that shared the resource with them.<br/>
        /// Default Value: all<br/>
        /// Example: all
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DubbingMetadataPageResponseModel> GetDubbingAsync(
            string? cursor = default,
            int? pageSize = default,
            global::ElevenLabs.ListDubsV1DubbingGetDubbingStatus? dubbingStatus = default,
            global::ElevenLabs.ListDubsV1DubbingGetFilterByCreator? filterByCreator = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}