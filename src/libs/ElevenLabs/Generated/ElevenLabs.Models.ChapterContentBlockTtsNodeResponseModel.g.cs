
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChapterContentBlockTtsNodeResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"tts_node"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tts_node";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_voice_ref_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectVoiceRefId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string VoiceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockTtsNodeResponseModel" /> class.
        /// </summary>
        /// <param name="projectVoiceRefId"></param>
        /// <param name="text"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChapterContentBlockTtsNodeResponseModel(
            string projectVoiceRefId,
            string text,
            string type = "tts_node")
        {
            this.Type = type;
            this.ProjectVoiceRefId = projectVoiceRefId ?? throw new global::System.ArgumentNullException(nameof(projectVoiceRefId));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChapterContentBlockTtsNodeResponseModel" /> class.
        /// </summary>
        public ChapterContentBlockTtsNodeResponseModel()
        {
        }

    }
}