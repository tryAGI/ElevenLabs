
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioReference), TypeInfoPropertyName = "AudioReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerationReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StaticAssetReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InlineAudioReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioReferenceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioReferenceDiscriminatorType), TypeInfoPropertyName = "AudioReferenceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance25Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance25RequestAspectRatio), TypeInfoPropertyName = "BytedanceSeedance25RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance25RequestResolution), TypeInfoPropertyName = "BytedanceSeedance25RequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ImageReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VideoReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoReference), TypeInfoPropertyName = "VideoReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AudioReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2FastRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio), TypeInfoPropertyName = "BytedanceSeedance2FastRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2FastRequestResolution), TypeInfoPropertyName = "BytedanceSeedance2FastRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2MiniRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio), TypeInfoPropertyName = "BytedanceSeedance2MiniRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestResolution), TypeInfoPropertyName = "BytedanceSeedance2MiniRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2RequestAspectRatio), TypeInfoPropertyName = "BytedanceSeedance2RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2RequestResolution), TypeInfoPropertyName = "BytedanceSeedance2RequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedream5LiteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio), TypeInfoPropertyName = "BytedanceSeedream5LiteRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestResolution), TypeInfoPropertyName = "BytedanceSeedream5LiteRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedream5ProRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio), TypeInfoPropertyName = "BytedanceSeedream5ProRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedream5ProRequestResolution), TypeInfoPropertyName = "BytedanceSeedream5ProRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatifyAuroraRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatifyAuroraRequestResolution), TypeInfoPropertyName = "CreatifyAuroraRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ElevenFlashV25Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ElevenFlashV25RequestOutputFormat), TypeInfoPropertyName = "ElevenFlashV25RequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.PronunciationDictionaryVersionLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryVersionLocator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ElevenFlashV25VoiceSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ElevenMultilingualV2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat), TypeInfoPropertyName = "ElevenMultilingualV2RequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TtsVoiceSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ElevenV3Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ElevenV3RequestOutputFormat), TypeInfoPropertyName = "ElevenV3RequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ElevenV3VoiceSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage1Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage1RequestQuality), TypeInfoPropertyName = "GPTImage1RequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage1RequestBackground), TypeInfoPropertyName = "GPTImage1RequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage1RequestAspectRatio), TypeInfoPropertyName = "GPTImage1RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage15Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage15RequestQuality), TypeInfoPropertyName = "GPTImage15RequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage15RequestBackground), TypeInfoPropertyName = "GPTImage15RequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage15RequestAspectRatio), TypeInfoPropertyName = "GPTImage15RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage2Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage2RequestQuality), TypeInfoPropertyName = "GPTImage2RequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage2RequestAspectRatio), TypeInfoPropertyName = "GPTImage2RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage2RequestResolution), TypeInfoPropertyName = "GPTImage2RequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini25FlashImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini25FlashImageRequestAspectRatio), TypeInfoPropertyName = "Gemini25FlashImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini31FlashImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini31FlashImageRequestAspectRatio), TypeInfoPropertyName = "Gemini31FlashImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini31FlashImageRequestResolution), TypeInfoPropertyName = "Gemini31FlashImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini31FlashLiteImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio), TypeInfoPropertyName = "Gemini31FlashLiteImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini3ProImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini3ProImageRequestAspectRatio), TypeInfoPropertyName = "Gemini3ProImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini3ProImageRequestResolution), TypeInfoPropertyName = "Gemini3ProImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageGenerationRequest), TypeInfoPropertyName = "ImageGenerationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageGenerationRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId), TypeInfoPropertyName = "ImageGenerationRequestDiscriminatorModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InlineImageReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageReferenceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageReferenceDiscriminatorType), TypeInfoPropertyName = "ImageReferenceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InlineAudioReferenceMimeType), TypeInfoPropertyName = "InlineAudioReferenceMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InlineImageReferenceMimeType), TypeInfoPropertyName = "InlineImageReferenceMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InlineVideoReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InlineVideoReferenceMimeType), TypeInfoPropertyName = "InlineVideoReferenceMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationCompletedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationFailedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationFailedResponseFailureReason), TypeInfoPropertyName = "MediaGenerationFailedResponseFailureReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationInProgressResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationInProgressResponseStatus), TypeInfoPropertyName = "MediaGenerationInProgressResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.MediaGenerationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationResponse), TypeInfoPropertyName = "MediaGenerationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus), TypeInfoPropertyName = "MediaGenerationResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechGenerationRequest), TypeInfoPropertyName = "TextToSpeechGenerationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId), TypeInfoPropertyName = "TextToSpeechGenerationRequestDiscriminatorModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Veo31FastRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Veo31FastRequestAspectRatio), TypeInfoPropertyName = "Veo31FastRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Veo31FastRequestResolution), TypeInfoPropertyName = "Veo31FastRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VeoImageReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VeoImageReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Veo31Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Veo31RequestAspectRatio), TypeInfoPropertyName = "Veo31RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Veo31RequestResolution), TypeInfoPropertyName = "Veo31RequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VeoImageReferenceRole), TypeInfoPropertyName = "VeoImageReferenceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoGenerationRequest), TypeInfoPropertyName = "VideoGenerationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoGenerationRequestDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId), TypeInfoPropertyName = "VideoGenerationRequestDiscriminatorModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoReferenceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoReferenceDiscriminatorType), TypeInfoPropertyName = "VideoReferenceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookTargetAll))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookTargetIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookTargetDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookTargetDiscriminatorType), TypeInfoPropertyName = "WebhookTargetDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListVideoGenerationsStatus), TypeInfoPropertyName = "ListVideoGenerationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListImageGenerationsStatus), TypeInfoPropertyName = "ListImageGenerationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListTextToSpeechGenerationsStatus), TypeInfoPropertyName = "ListTextToSpeechGenerationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioReference?), TypeInfoPropertyName = "NullableAudioReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioReferenceDiscriminatorType?), TypeInfoPropertyName = "NullableAudioReferenceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance25RequestAspectRatio?), TypeInfoPropertyName = "NullableBytedanceSeedance25RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance25RequestResolution?), TypeInfoPropertyName = "NullableBytedanceSeedance25RequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoReference?), TypeInfoPropertyName = "NullableVideoReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio?), TypeInfoPropertyName = "NullableBytedanceSeedance2FastRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2FastRequestResolution?), TypeInfoPropertyName = "NullableBytedanceSeedance2FastRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio?), TypeInfoPropertyName = "NullableBytedanceSeedance2MiniRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestResolution?), TypeInfoPropertyName = "NullableBytedanceSeedance2MiniRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2RequestAspectRatio?), TypeInfoPropertyName = "NullableBytedanceSeedance2RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedance2RequestResolution?), TypeInfoPropertyName = "NullableBytedanceSeedance2RequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio?), TypeInfoPropertyName = "NullableBytedanceSeedream5LiteRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestResolution?), TypeInfoPropertyName = "NullableBytedanceSeedream5LiteRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio?), TypeInfoPropertyName = "NullableBytedanceSeedream5ProRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BytedanceSeedream5ProRequestResolution?), TypeInfoPropertyName = "NullableBytedanceSeedream5ProRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreatifyAuroraRequestResolution?), TypeInfoPropertyName = "NullableCreatifyAuroraRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ElevenFlashV25RequestOutputFormat?), TypeInfoPropertyName = "NullableElevenFlashV25RequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat?), TypeInfoPropertyName = "NullableElevenMultilingualV2RequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ElevenV3RequestOutputFormat?), TypeInfoPropertyName = "NullableElevenV3RequestOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage1RequestQuality?), TypeInfoPropertyName = "NullableGPTImage1RequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage1RequestBackground?), TypeInfoPropertyName = "NullableGPTImage1RequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage1RequestAspectRatio?), TypeInfoPropertyName = "NullableGPTImage1RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage15RequestQuality?), TypeInfoPropertyName = "NullableGPTImage15RequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage15RequestBackground?), TypeInfoPropertyName = "NullableGPTImage15RequestBackground2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage15RequestAspectRatio?), TypeInfoPropertyName = "NullableGPTImage15RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage2RequestQuality?), TypeInfoPropertyName = "NullableGPTImage2RequestQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage2RequestAspectRatio?), TypeInfoPropertyName = "NullableGPTImage2RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GPTImage2RequestResolution?), TypeInfoPropertyName = "NullableGPTImage2RequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini25FlashImageRequestAspectRatio?), TypeInfoPropertyName = "NullableGemini25FlashImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini31FlashImageRequestAspectRatio?), TypeInfoPropertyName = "NullableGemini31FlashImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini31FlashImageRequestResolution?), TypeInfoPropertyName = "NullableGemini31FlashImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio?), TypeInfoPropertyName = "NullableGemini31FlashLiteImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini3ProImageRequestAspectRatio?), TypeInfoPropertyName = "NullableGemini3ProImageRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Gemini3ProImageRequestResolution?), TypeInfoPropertyName = "NullableGemini3ProImageRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageGenerationRequest?), TypeInfoPropertyName = "NullableImageGenerationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId?), TypeInfoPropertyName = "NullableImageGenerationRequestDiscriminatorModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ImageReferenceDiscriminatorType?), TypeInfoPropertyName = "NullableImageReferenceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InlineAudioReferenceMimeType?), TypeInfoPropertyName = "NullableInlineAudioReferenceMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InlineImageReferenceMimeType?), TypeInfoPropertyName = "NullableInlineImageReferenceMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.InlineVideoReferenceMimeType?), TypeInfoPropertyName = "NullableInlineVideoReferenceMimeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationFailedResponseFailureReason?), TypeInfoPropertyName = "NullableMediaGenerationFailedResponseFailureReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationInProgressResponseStatus?), TypeInfoPropertyName = "NullableMediaGenerationInProgressResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationResponse?), TypeInfoPropertyName = "NullableMediaGenerationResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus?), TypeInfoPropertyName = "NullableMediaGenerationResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechGenerationRequest?), TypeInfoPropertyName = "NullableTextToSpeechGenerationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId?), TypeInfoPropertyName = "NullableTextToSpeechGenerationRequestDiscriminatorModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Veo31FastRequestAspectRatio?), TypeInfoPropertyName = "NullableVeo31FastRequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Veo31FastRequestResolution?), TypeInfoPropertyName = "NullableVeo31FastRequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Veo31RequestAspectRatio?), TypeInfoPropertyName = "NullableVeo31RequestAspectRatio2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Veo31RequestResolution?), TypeInfoPropertyName = "NullableVeo31RequestResolution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VeoImageReferenceRole?), TypeInfoPropertyName = "NullableVeoImageReferenceRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoGenerationRequest?), TypeInfoPropertyName = "NullableVideoGenerationRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId?), TypeInfoPropertyName = "NullableVideoGenerationRequestDiscriminatorModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VideoReferenceDiscriminatorType?), TypeInfoPropertyName = "NullableVideoReferenceDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WebhookTargetDiscriminatorType?), TypeInfoPropertyName = "NullableWebhookTargetDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListVideoGenerationsStatus?), TypeInfoPropertyName = "NullableListVideoGenerationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListImageGenerationsStatus?), TypeInfoPropertyName = "NullableListImageGenerationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListTextToSpeechGenerationsStatus?), TypeInfoPropertyName = "NullableListTextToSpeechGenerationsStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ImageReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VideoReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AudioReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.PronunciationDictionaryVersionLocator>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.MediaGenerationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VeoImageReference>))]
    internal sealed partial class FlowsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FlowsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static FlowsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private FlowsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AudioReferenceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ImageGenerationRequestJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ImageReferenceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.MediaGenerationResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.TextToSpeechGenerationRequestJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VideoGenerationRequestJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.VideoReferenceJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.WebhookTargetJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, bool?, double?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::ElevenLabs.AudioReferenceDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.AudioReferenceDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.CreatifyAuroraRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.CreatifyAuroraRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenFlashV25RequestOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenFlashV25RequestOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenV3RequestOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ElevenV3RequestOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestQuality)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestQuality?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestBackground)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestBackground?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestQuality)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestQuality?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestBackground)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestBackground?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestQuality)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestQuality?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini25FlashImageRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini25FlashImageRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId)

                    || typeToConvert == typeof(global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId?)

                    || typeToConvert == typeof(global::ElevenLabs.ImageReferenceDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.ImageReferenceDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.InlineAudioReferenceMimeType)

                    || typeToConvert == typeof(global::ElevenLabs.InlineAudioReferenceMimeType?)

                    || typeToConvert == typeof(global::ElevenLabs.InlineImageReferenceMimeType)

                    || typeToConvert == typeof(global::ElevenLabs.InlineImageReferenceMimeType?)

                    || typeToConvert == typeof(global::ElevenLabs.InlineVideoReferenceMimeType)

                    || typeToConvert == typeof(global::ElevenLabs.InlineVideoReferenceMimeType?)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationFailedResponseFailureReason)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationFailedResponseFailureReason?)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationInProgressResponseStatus)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationInProgressResponseStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus)

                    || typeToConvert == typeof(global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId)

                    || typeToConvert == typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId?)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31RequestAspectRatio)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31RequestAspectRatio?)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31RequestResolution)

                    || typeToConvert == typeof(global::ElevenLabs.Veo31RequestResolution?)

                    || typeToConvert == typeof(global::ElevenLabs.VeoImageReferenceRole)

                    || typeToConvert == typeof(global::ElevenLabs.VeoImageReferenceRole?)

                    || typeToConvert == typeof(global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId)

                    || typeToConvert == typeof(global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId?)

                    || typeToConvert == typeof(global::ElevenLabs.VideoReferenceDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.VideoReferenceDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookTargetDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.WebhookTargetDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.ListVideoGenerationsStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ListVideoGenerationsStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ListImageGenerationsStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ListImageGenerationsStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ListTextToSpeechGenerationsStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ListTextToSpeechGenerationsStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.AudioReferenceDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.AudioReferenceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioReferenceDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.AudioReferenceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance25RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance25RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance25RequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance25RequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance25RequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2FastRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2FastRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2FastRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2FastRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2FastRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2MiniRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2MiniRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2MiniRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2MiniRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2MiniRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2RequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedance2RequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedance2RequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5LiteRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5LiteRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5LiteRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5LiteRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5LiteRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5ProRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5ProRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5ProRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BytedanceSeedream5ProRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.BytedanceSeedream5ProRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreatifyAuroraRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.CreatifyAuroraRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.CreatifyAuroraRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.CreatifyAuroraRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenFlashV25RequestOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenFlashV25RequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenFlashV25RequestOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenFlashV25RequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenMultilingualV2RequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenMultilingualV2RequestOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenMultilingualV2RequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenV3RequestOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenV3RequestOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ElevenV3RequestOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ElevenV3RequestOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestQuality))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestQuality?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestBackground))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestBackground?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage1RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage1RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestQuality))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestQuality?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestBackground))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestBackgroundJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestBackground?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestBackgroundNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage15RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage15RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestQuality))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestQuality?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GPTImage2RequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.GPTImage2RequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini25FlashImageRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini25FlashImageRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini25FlashImageRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini25FlashImageRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashImageRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashImageRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashImageRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashImageRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashImageRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashLiteImageRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini31FlashLiteImageRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini31FlashLiteImageRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini3ProImageRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini3ProImageRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini3ProImageRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Gemini3ProImageRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.Gemini3ProImageRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId))
                {
                    return new global::ElevenLabs.JsonConverters.ImageGenerationRequestDiscriminatorModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageGenerationRequestDiscriminatorModelId?))
                {
                    return new global::ElevenLabs.JsonConverters.ImageGenerationRequestDiscriminatorModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageReferenceDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.ImageReferenceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ImageReferenceDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.ImageReferenceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineAudioReferenceMimeType))
                {
                    return new global::ElevenLabs.JsonConverters.InlineAudioReferenceMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineAudioReferenceMimeType?))
                {
                    return new global::ElevenLabs.JsonConverters.InlineAudioReferenceMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineImageReferenceMimeType))
                {
                    return new global::ElevenLabs.JsonConverters.InlineImageReferenceMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineImageReferenceMimeType?))
                {
                    return new global::ElevenLabs.JsonConverters.InlineImageReferenceMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineVideoReferenceMimeType))
                {
                    return new global::ElevenLabs.JsonConverters.InlineVideoReferenceMimeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.InlineVideoReferenceMimeType?))
                {
                    return new global::ElevenLabs.JsonConverters.InlineVideoReferenceMimeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationFailedResponseFailureReason))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationFailedResponseFailureReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationFailedResponseFailureReason?))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationFailedResponseFailureReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationInProgressResponseStatus))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationInProgressResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationInProgressResponseStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationInProgressResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationResponseDiscriminatorStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.MediaGenerationResponseDiscriminatorStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechGenerationRequestDiscriminatorModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId?))
                {
                    return new global::ElevenLabs.JsonConverters.TextToSpeechGenerationRequestDiscriminatorModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31FastRequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31FastRequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31FastRequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31FastRequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31FastRequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31RequestAspectRatio))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31RequestAspectRatioJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31RequestAspectRatio?))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31RequestAspectRatioNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31RequestResolution))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31RequestResolutionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Veo31RequestResolution?))
                {
                    return new global::ElevenLabs.JsonConverters.Veo31RequestResolutionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VeoImageReferenceRole))
                {
                    return new global::ElevenLabs.JsonConverters.VeoImageReferenceRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VeoImageReferenceRole?))
                {
                    return new global::ElevenLabs.JsonConverters.VeoImageReferenceRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId))
                {
                    return new global::ElevenLabs.JsonConverters.VideoGenerationRequestDiscriminatorModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoGenerationRequestDiscriminatorModelId?))
                {
                    return new global::ElevenLabs.JsonConverters.VideoGenerationRequestDiscriminatorModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoReferenceDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.VideoReferenceDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VideoReferenceDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.VideoReferenceDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookTargetDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookTargetDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WebhookTargetDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.WebhookTargetDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListVideoGenerationsStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ListVideoGenerationsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListVideoGenerationsStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ListVideoGenerationsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListImageGenerationsStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ListImageGenerationsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListImageGenerationsStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ListImageGenerationsStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListTextToSpeechGenerationsStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ListTextToSpeechGenerationsStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListTextToSpeechGenerationsStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ListTextToSpeechGenerationsStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new FlowsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}