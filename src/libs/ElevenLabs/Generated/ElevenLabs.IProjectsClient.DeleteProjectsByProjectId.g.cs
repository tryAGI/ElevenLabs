#nullable enable

namespace ElevenLabs
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete Project<br/>
        /// Delete a project by its project_id.
        /// </summary>
        /// <param name="projectId">
        /// The project_id of the project, you can query GET https://api.elevenlabs.io/v1/projects to list all available projects.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteProjectsByProjectIdAsync(
            string projectId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}