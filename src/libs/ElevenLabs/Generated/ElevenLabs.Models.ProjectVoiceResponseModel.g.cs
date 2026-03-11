
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectVoiceResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Alias { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double Stability { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_boost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double SimilarityBoost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double Style { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_pinned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool IsPinned { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_speaker_boost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool UseSpeakerBoost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_gain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double VolumeGain { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double Speed { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVoiceResponseModel" /> class.
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="alias"></param>
        /// <param name="stability"></param>
        /// <param name="similarityBoost"></param>
        /// <param name="style"></param>
        /// <param name="isPinned"></param>
        /// <param name="useSpeakerBoost"></param>
        /// <param name="volumeGain"></param>
        /// <param name="speed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectVoiceResponseModel(
            string voiceId,
            string alias,
            double stability,
            double similarityBoost,
            double style,
            bool isPinned,
            bool useSpeakerBoost,
            double volumeGain,
            double speed)
        {
            this.VoiceId = voiceId ?? throw new global::System.ArgumentNullException(nameof(voiceId));
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
            this.Style = style;
            this.IsPinned = isPinned;
            this.UseSpeakerBoost = useSpeakerBoost;
            this.VolumeGain = volumeGain;
            this.Speed = speed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectVoiceResponseModel" /> class.
        /// </summary>
        public ProjectVoiceResponseModel()
        {
        }
    }
}