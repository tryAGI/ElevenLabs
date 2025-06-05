#nullable enable

namespace ElevenLabs
{
    public partial interface ISoundEffectsExploreClient
    {
        /// <summary>
        /// Get Shared Sound Effects<br/>
        /// Returns a list of shared sound effects.
        /// </summary>
        /// <param name="pageSize">
        /// How many sound effects to return at maximum. Can not exceed 100, defaults to 30.<br/>
        /// Default Value: 30
        /// </param>
        /// <param name="category">
        /// Sound effect category used for filtering.<br/>
        /// Example: Nature
        /// </param>
        /// <param name="search">
        /// Search term used for filtering<br/>
        /// Example: Cold water
        /// </param>
        /// <param name="sort">
        /// Sort criteria. Can be one of: created_date, download_count, like_count, trending_score. Defaults to trending_score.<br/>
        /// Default Value: trending_score<br/>
        /// Example: trending_score
        /// </param>
        /// <param name="featured">
        /// Filter featured sound effects.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.GetSharedSoundGenerationsResponseModel> GetSharedSoundGenerationsAsync(
            int? pageSize = default,
            global::ElevenLabs.GetSharedSoundEffectsV1SharedSoundGenerationsGetCategory? category = default,
            string? search = default,
            global::ElevenLabs.GetSharedSoundEffectsV1SharedSoundGenerationsGetSort? sort = default,
            bool? featured = default,
            int? page = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}