
#nullable enable

namespace ElevenLabs
{
    public partial class SamplesClient
    {
        partial void PrepareGetVoicesByVoiceIdSamplesBySampleIdAudioArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string voiceId,
            ref string sampleId,
            ref string? xiApiKey);
        partial void PrepareGetVoicesByVoiceIdSamplesBySampleIdAudioRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string voiceId,
            string sampleId,
            string? xiApiKey);
        partial void ProcessGetVoicesByVoiceIdSamplesBySampleIdAudioResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetVoicesByVoiceIdSamplesBySampleIdAudioResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Audio From Sample<br/>
        /// Returns the audio corresponding to a sample attached to a voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="sampleId">
        /// Sample ID to be used, you can use GET https://api.elevenlabs.io/v1/voices/{voice_id} to list all the available samples for a voice.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ElevenLabs.HTTPValidationError> GetVoicesByVoiceIdSamplesBySampleIdAudioAsync(
            string voiceId,
            string sampleId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetVoicesByVoiceIdSamplesBySampleIdAudioArguments(
                httpClient: _httpClient,
                voiceId: ref voiceId,
                sampleId: ref sampleId,
                xiApiKey: ref xiApiKey);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/voices/{voiceId}/samples/{sampleId}/audio",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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
            PrepareGetVoicesByVoiceIdSamplesBySampleIdAudioRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                voiceId: voiceId,
                sampleId: sampleId,
                xiApiKey: xiApiKey);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetVoicesByVoiceIdSamplesBySampleIdAudioResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetVoicesByVoiceIdSamplesBySampleIdAudioResponseContent(
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