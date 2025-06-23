#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Update Default Sharing Preferences<br/>
        /// Update the user's default sharing preferences.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWorkspaceDefaultSharingPreferencesAsync(
            global::ElevenLabs.BodyUpdateDefaultSharingPreferencesV1WorkspaceDefaultSharingPreferencesPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Default Sharing Preferences<br/>
        /// Update the user's default sharing preferences.
        /// </summary>
        /// <param name="defaultSharingGroups">
        /// List of group IDs to share with by default
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWorkspaceDefaultSharingPreferencesAsync(
            global::System.Collections.Generic.IList<string> defaultSharingGroups,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}