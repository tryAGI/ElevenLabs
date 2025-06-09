#nullable enable

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Update User Auto Provisioning<br/>
        /// Update user auto provisioning settings for the workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWorkspaceUserAutoProvisioningAsync(
            global::ElevenLabs.BodyUpdateUserAutoProvisioningV1WorkspaceUserAutoProvisioningPost request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update User Auto Provisioning<br/>
        /// Update user auto provisioning settings for the workspace.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateWorkspaceUserAutoProvisioningAsync(
            bool enabled,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}