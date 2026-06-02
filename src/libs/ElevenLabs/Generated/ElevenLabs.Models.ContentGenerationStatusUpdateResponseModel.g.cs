
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentGenerationStatusUpdateResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Default Value: pending
        /// </summary>
        /// <default>global::ElevenLabs.ContentGenerationStatus.Pending</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ContentGenerationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ContentGenerationStatus Status { get; set; } = global::ElevenLabs.ContentGenerationStatus.Pending;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ContentModalityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ContentModality Modality { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_url")]
        public string? ContentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_capped_resolution_url")]
        public string? ContentCappedResolutionUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_content_url")]
        public string? PreviewContentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        public string? ThumbnailUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public global::ElevenLabs.ContentGenerationFailureReason? FailureReason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_content")]
        public string? InlineContent { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_prompt_rewrite_possible")]
        public bool? IsPromptRewritePossible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_node_id")]
        public string? TemplateNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runnable_at_unix")]
        public int? RunnableAtUnix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGenerationStatusUpdateResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="generationSessionId"></param>
        /// <param name="userId"></param>
        /// <param name="status">
        /// Default Value: pending
        /// </param>
        /// <param name="modality"></param>
        /// <param name="contentUrl"></param>
        /// <param name="contentCappedResolutionUrl"></param>
        /// <param name="previewContentUrl"></param>
        /// <param name="thumbnailUrl"></param>
        /// <param name="errorMessage"></param>
        /// <param name="failureReason"></param>
        /// <param name="inlineContent"></param>
        /// <param name="isPromptRewritePossible">
        /// Default Value: false
        /// </param>
        /// <param name="templateId"></param>
        /// <param name="templateNodeId"></param>
        /// <param name="runnableAtUnix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentGenerationStatusUpdateResponseModel(
            string id,
            string generationSessionId,
            string userId,
            global::ElevenLabs.ContentGenerationStatus status,
            global::ElevenLabs.ContentModality modality,
            string? contentUrl,
            string? contentCappedResolutionUrl,
            string? previewContentUrl,
            string? thumbnailUrl,
            string? errorMessage,
            global::ElevenLabs.ContentGenerationFailureReason? failureReason,
            string? inlineContent,
            bool? isPromptRewritePossible,
            string? templateId,
            string? templateNodeId,
            int? runnableAtUnix)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.GenerationSessionId = generationSessionId ?? throw new global::System.ArgumentNullException(nameof(generationSessionId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Status = status;
            this.Modality = modality;
            this.ContentUrl = contentUrl;
            this.ContentCappedResolutionUrl = contentCappedResolutionUrl;
            this.PreviewContentUrl = previewContentUrl;
            this.ThumbnailUrl = thumbnailUrl;
            this.ErrorMessage = errorMessage;
            this.FailureReason = failureReason;
            this.InlineContent = inlineContent;
            this.IsPromptRewritePossible = isPromptRewritePossible;
            this.TemplateId = templateId;
            this.TemplateNodeId = templateNodeId;
            this.RunnableAtUnix = runnableAtUnix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGenerationStatusUpdateResponseModel" /> class.
        /// </summary>
        public ContentGenerationStatusUpdateResponseModel()
        {
        }

    }
}