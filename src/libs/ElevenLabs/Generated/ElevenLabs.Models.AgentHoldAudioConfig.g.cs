
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Custom hold audio played on loop to callers waiting in the agent's queue.<br/>
    /// Set by uploading a file through the agent hold-audio endpoint. Values sent in<br/>
    /// agent create or update requests are ignored.
    /// </summary>
    public sealed partial class AgentHoldAudioConfig
    {
        /// <summary>
        /// Storage path of the uploaded clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioPath { get; set; }

        /// <summary>
        /// Public CDN URL of the uploaded clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AudioUrl { get; set; }

        /// <summary>
        /// Filename of the uploaded clip as provided by the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalFilename { get; set; }

        /// <summary>
        /// Duration of the uploaded clip in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DurationSecs { get; set; }

        /// <summary>
        /// Size of the uploaded clip in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentHoldAudioConfig" /> class.
        /// </summary>
        /// <param name="audioPath">
        /// Storage path of the uploaded clip
        /// </param>
        /// <param name="audioUrl">
        /// Public CDN URL of the uploaded clip
        /// </param>
        /// <param name="originalFilename">
        /// Filename of the uploaded clip as provided by the user
        /// </param>
        /// <param name="durationSecs">
        /// Duration of the uploaded clip in seconds
        /// </param>
        /// <param name="sizeBytes">
        /// Size of the uploaded clip in bytes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentHoldAudioConfig(
            string audioPath,
            string audioUrl,
            string originalFilename,
            double durationSecs,
            long sizeBytes)
        {
            this.AudioPath = audioPath ?? throw new global::System.ArgumentNullException(nameof(audioPath));
            this.AudioUrl = audioUrl ?? throw new global::System.ArgumentNullException(nameof(audioUrl));
            this.OriginalFilename = originalFilename ?? throw new global::System.ArgumentNullException(nameof(originalFilename));
            this.DurationSecs = durationSecs;
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentHoldAudioConfig" /> class.
        /// </summary>
        public AgentHoldAudioConfig()
        {
        }

    }
}