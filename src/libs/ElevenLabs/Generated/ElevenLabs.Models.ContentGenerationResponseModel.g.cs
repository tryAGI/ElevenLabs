
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentGenerationResponseModel
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
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        public string? Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_prompt")]
        public object? DisplayPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ModelIDJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ModelID ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.Veo3Parameters, global::ElevenLabs.Veo2Parameters, global::ElevenLabs.Veo2ExpParameters, global::ElevenLabs.Veo31Parameters, global::ElevenLabs.Veo31FastParameters, global::ElevenLabs.Veo31LiteParameters, global::ElevenLabs.GeminiImageParameters, global::ElevenLabs.GeminiImageProParameters, global::ElevenLabs.Gemini31FlashImageParameters, global::ElevenLabs.Imagen4FastParameters, global::ElevenLabs.Imagen4Parameters, global::ElevenLabs.Sora2Parameters, global::ElevenLabs.Sora2ProParameters, global::ElevenLabs.GPTImageParameters, global::ElevenLabs.GPTImage2Parameters, global::ElevenLabs.Kling25TurboParameters, global::ElevenLabs.Kling26ProParameters, global::ElevenLabs.KlingOmniVideoParameters, global::ElevenLabs.KlingOmniImageParameters, global::ElevenLabs.KlingO3ProParameters, global::ElevenLabs.Kling3ProParameters, global::ElevenLabs.Flux1KontextParameters, global::ElevenLabs.Flux2ProParameters, global::ElevenLabs.KreaV2Parameters, global::ElevenLabs.BytedanceSeedanceParameters, global::ElevenLabs.BytedanceSeedance15ProParameters, global::ElevenLabs.BytedanceSeedance2Parameters, global::ElevenLabs.BytedanceSeedance2FastParameters, global::ElevenLabs.BytedanceSeedream4Parameters, global::ElevenLabs.BytedanceSeedream45Parameters, global::ElevenLabs.BytedanceSeedream5LiteParameters, global::ElevenLabs.Wan25PreviewImageParameters, global::ElevenLabs.Wan25PreviewVideoParameters, global::ElevenLabs.Wan26Parameters, global::ElevenLabs.LTXV2Parameters, global::ElevenLabs.LTXV2FastParameters, global::ElevenLabs.RunwayGen45Parameters, global::ElevenLabs.RunwayGen4ImageParameters, global::ElevenLabs.TestParameters, global::ElevenLabs.ElevenLabsTTSParameters, global::ElevenLabs.ElevenLabsSFXParameters, global::ElevenLabs.ElevenLabsMusicParameters, global::ElevenLabs.GeminiLLMParameters, global::ElevenLabs.ElevenLabsDubbingParameters, global::ElevenLabs.ElevenLabsCompositionParameters, global::ElevenLabs.ElevenLabsSTTParameters, global::ElevenLabs.Kling26ProMotionControlParameters, global::ElevenLabs.Kling3ProMotionControlParameters, global::ElevenLabs.KlingOmniEditVideoParameters, global::ElevenLabs.KlingO3EditVideoParameters, global::ElevenLabs.TopazImageUpscaleParameters, global::ElevenLabs.TopazVideoUpscaleParameters, global::ElevenLabs.BiRefNetBgRemovalParameters, global::ElevenLabs.SyncLipSyncParameters, global::ElevenLabs.SyncLipSyncV3Parameters, global::ElevenLabs.VeedLipSyncParameters, global::ElevenLabs.VeedFabricParameters, global::ElevenLabs.BytedanceOmniHumanParameters, global::ElevenLabs.CreatifyAuroraParameters, global::ElevenLabs.HeygenAvatar4Parameters, global::ElevenLabs.LTXV2RetakeParameters, global::ElevenLabs.LTXAudioToVideoParameters, global::ElevenLabs.RunwayGen4TurboParameters, global::ElevenLabs.RunwayGen4AlephParameters, global::ElevenLabs.RunwayActTwoParameters, global::ElevenLabs.RunwayGen4ImageTurboParameters, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnyOf<global::ElevenLabs.Veo3Parameters, global::ElevenLabs.Veo2Parameters, global::ElevenLabs.Veo2ExpParameters, global::ElevenLabs.Veo31Parameters, global::ElevenLabs.Veo31FastParameters, global::ElevenLabs.Veo31LiteParameters, global::ElevenLabs.GeminiImageParameters, global::ElevenLabs.GeminiImageProParameters, global::ElevenLabs.Gemini31FlashImageParameters, global::ElevenLabs.Imagen4FastParameters, global::ElevenLabs.Imagen4Parameters, global::ElevenLabs.Sora2Parameters, global::ElevenLabs.Sora2ProParameters, global::ElevenLabs.GPTImageParameters, global::ElevenLabs.GPTImage2Parameters, global::ElevenLabs.Kling25TurboParameters, global::ElevenLabs.Kling26ProParameters, global::ElevenLabs.KlingOmniVideoParameters, global::ElevenLabs.KlingOmniImageParameters, global::ElevenLabs.KlingO3ProParameters, global::ElevenLabs.Kling3ProParameters, global::ElevenLabs.Flux1KontextParameters, global::ElevenLabs.Flux2ProParameters, global::ElevenLabs.KreaV2Parameters, global::ElevenLabs.BytedanceSeedanceParameters, global::ElevenLabs.BytedanceSeedance15ProParameters, global::ElevenLabs.BytedanceSeedance2Parameters, global::ElevenLabs.BytedanceSeedance2FastParameters, global::ElevenLabs.BytedanceSeedream4Parameters, global::ElevenLabs.BytedanceSeedream45Parameters, global::ElevenLabs.BytedanceSeedream5LiteParameters, global::ElevenLabs.Wan25PreviewImageParameters, global::ElevenLabs.Wan25PreviewVideoParameters, global::ElevenLabs.Wan26Parameters, global::ElevenLabs.LTXV2Parameters, global::ElevenLabs.LTXV2FastParameters, global::ElevenLabs.RunwayGen45Parameters, global::ElevenLabs.RunwayGen4ImageParameters, global::ElevenLabs.TestParameters, global::ElevenLabs.ElevenLabsTTSParameters, global::ElevenLabs.ElevenLabsSFXParameters, global::ElevenLabs.ElevenLabsMusicParameters, global::ElevenLabs.GeminiLLMParameters, global::ElevenLabs.ElevenLabsDubbingParameters, global::ElevenLabs.ElevenLabsCompositionParameters, global::ElevenLabs.ElevenLabsSTTParameters, global::ElevenLabs.Kling26ProMotionControlParameters, global::ElevenLabs.Kling3ProMotionControlParameters, global::ElevenLabs.KlingOmniEditVideoParameters, global::ElevenLabs.KlingO3EditVideoParameters, global::ElevenLabs.TopazImageUpscaleParameters, global::ElevenLabs.TopazVideoUpscaleParameters, global::ElevenLabs.BiRefNetBgRemovalParameters, global::ElevenLabs.SyncLipSyncParameters, global::ElevenLabs.SyncLipSyncV3Parameters, global::ElevenLabs.VeedLipSyncParameters, global::ElevenLabs.VeedFabricParameters, global::ElevenLabs.BytedanceOmniHumanParameters, global::ElevenLabs.CreatifyAuroraParameters, global::ElevenLabs.HeygenAvatar4Parameters, global::ElevenLabs.LTXV2RetakeParameters, global::ElevenLabs.LTXAudioToVideoParameters, global::ElevenLabs.RunwayGen4TurboParameters, global::ElevenLabs.RunwayGen4AlephParameters, global::ElevenLabs.RunwayActTwoParameters, global::ElevenLabs.RunwayGen4ImageTurboParameters, object> ModelParameters { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_mime_type")]
        public string? PreviewMimeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_properties")]
        public global::ElevenLabs.FilePropertiesResponseModel? FileProperties { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("blur_data_url")]
        public string? BlurDataUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_content")]
        public string? InlineContent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failure_reason")]
        public global::ElevenLabs.ContentGenerationFailureReason? FailureReason { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_prompt_rewrite_possible")]
        public bool? IsPromptRewritePossible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public global::ElevenLabs.ContentGenerationPriceResponseModel? Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_alignment")]
        public global::ElevenLabs.TextAlignmentResponseModel? TextAlignment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at_unix")]
        public int? FinishedAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runnable_at_unix")]
        public int? RunnableAtUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GenerationSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_iteration_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionIterationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_node_id")]
        public string? TemplateNodeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_polling_id")]
        public string? ExternalPollingId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references_folder_id")]
        public string? ReferencesFolderId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references_auto_resolved")]
        public bool? ReferencesAutoResolved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGenerationResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="modelId"></param>
        /// <param name="modelParameters"></param>
        /// <param name="modality"></param>
        /// <param name="status">
        /// Default Value: pending
        /// </param>
        /// <param name="createdAtUnix"></param>
        /// <param name="updatedAtUnix"></param>
        /// <param name="generationSessionId"></param>
        /// <param name="sessionIterationId"></param>
        /// <param name="prompt"></param>
        /// <param name="displayPrompt"></param>
        /// <param name="mimeType"></param>
        /// <param name="previewMimeType"></param>
        /// <param name="fileProperties"></param>
        /// <param name="errorMessage"></param>
        /// <param name="contentUrl"></param>
        /// <param name="contentCappedResolutionUrl"></param>
        /// <param name="previewContentUrl"></param>
        /// <param name="thumbnailUrl"></param>
        /// <param name="blurDataUrl"></param>
        /// <param name="inlineContent"></param>
        /// <param name="failureReason"></param>
        /// <param name="isPromptRewritePossible">
        /// Default Value: false
        /// </param>
        /// <param name="price"></param>
        /// <param name="textAlignment"></param>
        /// <param name="finishedAtUnix"></param>
        /// <param name="runnableAtUnix"></param>
        /// <param name="templateNodeId"></param>
        /// <param name="externalPollingId"></param>
        /// <param name="referencesFolderId"></param>
        /// <param name="referencesAutoResolved">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentGenerationResponseModel(
            string id,
            string userId,
            string workspaceId,
            global::ElevenLabs.ModelID modelId,
            global::ElevenLabs.AnyOf<global::ElevenLabs.Veo3Parameters, global::ElevenLabs.Veo2Parameters, global::ElevenLabs.Veo2ExpParameters, global::ElevenLabs.Veo31Parameters, global::ElevenLabs.Veo31FastParameters, global::ElevenLabs.Veo31LiteParameters, global::ElevenLabs.GeminiImageParameters, global::ElevenLabs.GeminiImageProParameters, global::ElevenLabs.Gemini31FlashImageParameters, global::ElevenLabs.Imagen4FastParameters, global::ElevenLabs.Imagen4Parameters, global::ElevenLabs.Sora2Parameters, global::ElevenLabs.Sora2ProParameters, global::ElevenLabs.GPTImageParameters, global::ElevenLabs.GPTImage2Parameters, global::ElevenLabs.Kling25TurboParameters, global::ElevenLabs.Kling26ProParameters, global::ElevenLabs.KlingOmniVideoParameters, global::ElevenLabs.KlingOmniImageParameters, global::ElevenLabs.KlingO3ProParameters, global::ElevenLabs.Kling3ProParameters, global::ElevenLabs.Flux1KontextParameters, global::ElevenLabs.Flux2ProParameters, global::ElevenLabs.KreaV2Parameters, global::ElevenLabs.BytedanceSeedanceParameters, global::ElevenLabs.BytedanceSeedance15ProParameters, global::ElevenLabs.BytedanceSeedance2Parameters, global::ElevenLabs.BytedanceSeedance2FastParameters, global::ElevenLabs.BytedanceSeedream4Parameters, global::ElevenLabs.BytedanceSeedream45Parameters, global::ElevenLabs.BytedanceSeedream5LiteParameters, global::ElevenLabs.Wan25PreviewImageParameters, global::ElevenLabs.Wan25PreviewVideoParameters, global::ElevenLabs.Wan26Parameters, global::ElevenLabs.LTXV2Parameters, global::ElevenLabs.LTXV2FastParameters, global::ElevenLabs.RunwayGen45Parameters, global::ElevenLabs.RunwayGen4ImageParameters, global::ElevenLabs.TestParameters, global::ElevenLabs.ElevenLabsTTSParameters, global::ElevenLabs.ElevenLabsSFXParameters, global::ElevenLabs.ElevenLabsMusicParameters, global::ElevenLabs.GeminiLLMParameters, global::ElevenLabs.ElevenLabsDubbingParameters, global::ElevenLabs.ElevenLabsCompositionParameters, global::ElevenLabs.ElevenLabsSTTParameters, global::ElevenLabs.Kling26ProMotionControlParameters, global::ElevenLabs.Kling3ProMotionControlParameters, global::ElevenLabs.KlingOmniEditVideoParameters, global::ElevenLabs.KlingO3EditVideoParameters, global::ElevenLabs.TopazImageUpscaleParameters, global::ElevenLabs.TopazVideoUpscaleParameters, global::ElevenLabs.BiRefNetBgRemovalParameters, global::ElevenLabs.SyncLipSyncParameters, global::ElevenLabs.SyncLipSyncV3Parameters, global::ElevenLabs.VeedLipSyncParameters, global::ElevenLabs.VeedFabricParameters, global::ElevenLabs.BytedanceOmniHumanParameters, global::ElevenLabs.CreatifyAuroraParameters, global::ElevenLabs.HeygenAvatar4Parameters, global::ElevenLabs.LTXV2RetakeParameters, global::ElevenLabs.LTXAudioToVideoParameters, global::ElevenLabs.RunwayGen4TurboParameters, global::ElevenLabs.RunwayGen4AlephParameters, global::ElevenLabs.RunwayActTwoParameters, global::ElevenLabs.RunwayGen4ImageTurboParameters, object> modelParameters,
            global::ElevenLabs.ContentModality modality,
            global::ElevenLabs.ContentGenerationStatus status,
            int createdAtUnix,
            int updatedAtUnix,
            string generationSessionId,
            string sessionIterationId,
            string? prompt,
            object? displayPrompt,
            string? mimeType,
            string? previewMimeType,
            global::ElevenLabs.FilePropertiesResponseModel? fileProperties,
            string? errorMessage,
            string? contentUrl,
            string? contentCappedResolutionUrl,
            string? previewContentUrl,
            string? thumbnailUrl,
            string? blurDataUrl,
            string? inlineContent,
            global::ElevenLabs.ContentGenerationFailureReason? failureReason,
            bool? isPromptRewritePossible,
            global::ElevenLabs.ContentGenerationPriceResponseModel? price,
            global::ElevenLabs.TextAlignmentResponseModel? textAlignment,
            int? finishedAtUnix,
            int? runnableAtUnix,
            string? templateNodeId,
            string? externalPollingId,
            string? referencesFolderId,
            bool? referencesAutoResolved)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.Prompt = prompt;
            this.DisplayPrompt = displayPrompt;
            this.ModelId = modelId;
            this.ModelParameters = modelParameters;
            this.Modality = modality;
            this.MimeType = mimeType;
            this.PreviewMimeType = previewMimeType;
            this.FileProperties = fileProperties;
            this.Status = status;
            this.ErrorMessage = errorMessage;
            this.ContentUrl = contentUrl;
            this.ContentCappedResolutionUrl = contentCappedResolutionUrl;
            this.PreviewContentUrl = previewContentUrl;
            this.ThumbnailUrl = thumbnailUrl;
            this.BlurDataUrl = blurDataUrl;
            this.InlineContent = inlineContent;
            this.FailureReason = failureReason;
            this.IsPromptRewritePossible = isPromptRewritePossible;
            this.Price = price;
            this.TextAlignment = textAlignment;
            this.CreatedAtUnix = createdAtUnix;
            this.UpdatedAtUnix = updatedAtUnix;
            this.FinishedAtUnix = finishedAtUnix;
            this.RunnableAtUnix = runnableAtUnix;
            this.GenerationSessionId = generationSessionId ?? throw new global::System.ArgumentNullException(nameof(generationSessionId));
            this.SessionIterationId = sessionIterationId ?? throw new global::System.ArgumentNullException(nameof(sessionIterationId));
            this.TemplateNodeId = templateNodeId;
            this.ExternalPollingId = externalPollingId;
            this.ReferencesFolderId = referencesFolderId;
            this.ReferencesAutoResolved = referencesAutoResolved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentGenerationResponseModel" /> class.
        /// </summary>
        public ContentGenerationResponseModel()
        {
        }

    }
}