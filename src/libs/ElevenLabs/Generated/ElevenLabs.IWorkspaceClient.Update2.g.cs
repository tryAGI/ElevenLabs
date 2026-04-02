#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs
{
    public partial interface IWorkspaceClient
    {
        /// <summary>
        /// Update Member<br/>
        /// Updates attributes of a workspace member. Apart from the email identifier, all parameters will remain unchanged unless specified. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateWorkspaceMemberResponseModel> Update2Async(

            global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Member<br/>
        /// Updates attributes of a workspace member. Apart from the email identifier, all parameters will remain unchanged unless specified. This endpoint may only be called by workspace administrators.
        /// </summary>
        /// <param name="email">
        /// Email of the target user.
        /// </param>
        /// <param name="isLocked">
        /// Whether to lock or unlock the user account.
        /// </param>
        /// <param name="workspaceSeatType">
        /// The workspace seat type
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.UpdateWorkspaceMemberResponseModel> Update2Async(
            string email,
            bool? isLocked = default,
            global::ElevenLabs.SeatType? workspaceSeatType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}