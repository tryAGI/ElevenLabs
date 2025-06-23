#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Get Default Sharing Preferences<br/>
        /// Get the user's default sharing preferences.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.DefaultSharingPreferencesResponseModel> GetWorkspaceDefaultSharingPreferencesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}