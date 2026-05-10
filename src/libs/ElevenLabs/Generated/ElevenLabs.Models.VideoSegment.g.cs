
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoSegment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subjects")]
        public global::System.Collections.Generic.IList<string>? Subjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shot_type")]
        public string? ShotType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("camera_movement")]
        public string? CameraMovement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transition_in")]
        public string? TransitionIn { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_speech")]
        public bool? HasSpeech { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_music")]
        public bool? HasMusic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pacing")]
        public string? Pacing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegment" /> class.
        /// </summary>
        /// <param name="startMs"></param>
        /// <param name="endMs"></param>
        /// <param name="description"></param>
        /// <param name="subjects"></param>
        /// <param name="shotType"></param>
        /// <param name="cameraMovement"></param>
        /// <param name="transitionIn"></param>
        /// <param name="hasSpeech">
        /// Default Value: false
        /// </param>
        /// <param name="hasMusic">
        /// Default Value: false
        /// </param>
        /// <param name="pacing"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoSegment(
            int startMs,
            int endMs,
            string description,
            global::System.Collections.Generic.IList<string>? subjects,
            string? shotType,
            string? cameraMovement,
            string? transitionIn,
            bool? hasSpeech,
            bool? hasMusic,
            string? pacing)
        {
            this.StartMs = startMs;
            this.EndMs = endMs;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Subjects = subjects;
            this.ShotType = shotType;
            this.CameraMovement = cameraMovement;
            this.TransitionIn = transitionIn;
            this.HasSpeech = hasSpeech;
            this.HasMusic = hasMusic;
            this.Pacing = pacing;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoSegment" /> class.
        /// </summary>
        public VideoSegment()
        {
        }

    }
}