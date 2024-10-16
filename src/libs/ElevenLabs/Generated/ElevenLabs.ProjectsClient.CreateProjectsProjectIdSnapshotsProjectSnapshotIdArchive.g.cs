
#nullable enable

namespace ElevenLabs
{
    public partial class ProjectsClient
    {
        partial void PrepareCreateProjectsProjectIdSnapshotsProjectSnapshotIdArchiveArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string projectSnapshotId,
            ref string? xiApiKey);
        partial void PrepareCreateProjectsProjectIdSnapshotsProjectSnapshotIdArchiveRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string projectSnapshotId,
            string? xiApiKey);
        partial void ProcessCreateProjectsProjectIdSnapshotsProjectSnapshotIdArchiveResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateProjectsProjectIdSnapshotsProjectSnapshotIdArchiveResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Streams Archive With Project Audio<br/>
        /// Streams archive with project audio.
        /// </summary>
        /// <param name="projectId">
        /// The project_id of the project, you can query GET https://api.elevenlabs.io/v1/projects to list all available projects.
        /// </param>
        /// <param name="projectSnapshotId">
        /// The project_snapshot_id of the project snapshot. You can query GET /v1/projects/{project_id}/snapshots to list all available snapshots for a project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.HTTPValidationError> CreateProjectsProjectIdSnapshotsProjectSnapshotIdArchiveAsync(
            string projectId,
            string projectSnapshotId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCreateProjectsProjectIdSnapshotsProjectSnapshotIdArchiveArguments(
                httpClient: _httpClient,
                projectId: ref projectId,
                projectSnapshotId: ref projectSnapshotId,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/projects/{projectId}/snapshots/{projectSnapshotId}/archive",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            if (xiApiKey != default)
            {
                httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }


            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateProjectsProjectIdSnapshotsProjectSnapshotIdArchiveRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                projectId: projectId,
                projectSnapshotId: projectSnapshotId,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateProjectsProjectIdSnapshotsProjectSnapshotIdArchiveResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateProjectsProjectIdSnapshotsProjectSnapshotIdArchiveResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::ElevenLabs.HTTPValidationError.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}