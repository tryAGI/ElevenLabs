#nullable enable

namespace ElevenLabs
{
    public partial interface ISpeechToTextEvaluationClient
    {
        /// <summary>
        /// Get Evaluation Analytics
        /// </summary>
        /// <param name="days">
        /// Default Value: 30
        /// </param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.EvaluationAnalyticsResponse> GetSpeechToTextEvaluationAnalyticsAsync(
            int? days = default,
            string? createdAfter = default,
            string? createdBefore = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}