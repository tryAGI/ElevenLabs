
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost
    {
        /// <summary>
        /// An MP3 or WAV file played on loop to callers waiting in the agent's concurrency wait queue. Maximum size 40 MB, maximum duration 180 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hold_audio_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] HoldAudioFile { get; set; }

        /// <summary>
        /// An MP3 or WAV file played on loop to callers waiting in the agent's concurrency wait queue. Maximum size 40 MB, maximum duration 180 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hold_audio_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HoldAudioFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost" /> class.
        /// </summary>
        /// <param name="holdAudioFile">
        /// An MP3 or WAV file played on loop to callers waiting in the agent's concurrency wait queue. Maximum size 40 MB, maximum duration 180 seconds.
        /// </param>
        /// <param name="holdAudioFilename">
        /// An MP3 or WAV file played on loop to callers waiting in the agent's concurrency wait queue. Maximum size 40 MB, maximum duration 180 seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost(
            byte[] holdAudioFile,
            string holdAudioFilename)
        {
            this.HoldAudioFile = holdAudioFile ?? throw new global::System.ArgumentNullException(nameof(holdAudioFile));
            this.HoldAudioFilename = holdAudioFilename ?? throw new global::System.ArgumentNullException(nameof(holdAudioFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost" /> class.
        /// </summary>
        public BodyPostAgentHoldAudioV1ConvaiAgentsAgentIdHoldAudioPost()
        {
        }

    }
}