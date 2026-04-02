#nullable enable

namespace ElevenLabs
{
    public partial interface IDubbingClient
    {
        /// <summary>
        /// Move Segments Between Speakers<br/>
        /// Change the attribution of one or more segments to a different speaker.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ElevenLabs.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentMigrationResponse> MigrateSegmentsAsync(
            string dubbingId,

            global::ElevenLabs.BodyMoveSegmentsBetweenSpeakersV1DubbingResourceDubbingIdMigrateSegmentsPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Move Segments Between Speakers<br/>
        /// Change the attribution of one or more segments to a different speaker.
        /// </summary>
        /// <param name="dubbingId">
        /// ID of the dubbing project.
        /// </param>
        /// <param name="segmentIds"></param>
        /// <param name="speakerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ElevenLabs.SegmentMigrationResponse> MigrateSegmentsAsync(
            string dubbingId,
            global::System.Collections.Generic.IList<string> segmentIds,
            string speakerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}