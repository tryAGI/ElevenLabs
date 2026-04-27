
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A generation node response that runs a model.<br/>
    /// Example: {"active_generation_id":"gen_abc123","id":"J3Pbu5gP6NNKBscdCdwB","label":"Generate Image","model_id":"gemini-2.5-flash-image","model_parameters":{"aspect_ratio":"16:9","images":[{"template_node_id":"K8Qnx2mR4PPLCteeDfxC"}]},"position":{"x":300,"y":150},"prompt":"A sunset over mountains","template_id":"tmpl_abc123","type":"generation"}
    /// </summary>
    public sealed partial class GenerationNode
    {
        /// <summary>
        /// Globally unique identifier for this node (must be unique across all templates). Clients must generate a random alphanumeric ID with sufficient entropy to avoid collisions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Label for the node, displayed in the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// ID of the template this node belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// Position of the node on the canvas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.NodePosition Position { get; set; }

        /// <summary>
        /// User ID of the person who last modified this node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_by")]
        public string? ModifiedBy { get; set; }

        /// <summary>
        /// When this node was last modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at_utc")]
        public global::System.DateTime? ModifiedAtUtc { get; set; }

        /// <summary>
        /// Default Value: generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The model to use (e.g., 'gemini-2.5-flash-image', 'veo-3.1-generate-001').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ModelIDJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ModelID ModelId { get; set; }

        /// <summary>
        /// The prompt for this node. Can be a literal string or a reference to another node's output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.ReferenceText, object>))]
        public global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? Prompt { get; set; }

        /// <summary>
        /// Rich text representation of the prompt preserving formatting and inline components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_prompt")]
        public object? DisplayPrompt { get; set; }

        /// <summary>
        /// Model-specific parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_parameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.Veo3Parameters, global::ElevenLabs.Veo2Parameters, global::ElevenLabs.Veo2ExpParameters, global::ElevenLabs.Veo31Parameters, global::ElevenLabs.Veo31FastParameters, global::ElevenLabs.Veo31LiteParameters, global::ElevenLabs.GeminiImageParameters, global::ElevenLabs.GeminiImageProParameters, global::ElevenLabs.Gemini31FlashImageParameters, global::ElevenLabs.Imagen4FastParameters, global::ElevenLabs.Imagen4Parameters, global::ElevenLabs.Sora2Parameters, global::ElevenLabs.Sora2ProParameters, global::ElevenLabs.GPTImageParameters, global::ElevenLabs.GPTImage2Parameters, global::ElevenLabs.Kling25TurboParameters, global::ElevenLabs.Kling26ProParameters, global::ElevenLabs.KlingOmniVideoParameters, global::ElevenLabs.KlingOmniImageParameters, global::ElevenLabs.KlingO3ProParameters, global::ElevenLabs.Kling3ProParameters, global::ElevenLabs.Flux1KontextParameters, global::ElevenLabs.Flux2ProParameters, global::ElevenLabs.BytedanceSeedanceParameters, global::ElevenLabs.BytedanceSeedance15ProParameters, global::ElevenLabs.BytedanceSeedance2Parameters, global::ElevenLabs.BytedanceSeedance2FastParameters, global::ElevenLabs.BytedanceSeedream4Parameters, global::ElevenLabs.BytedanceSeedream45Parameters, global::ElevenLabs.BytedanceSeedream5LiteParameters, global::ElevenLabs.Wan25PreviewImageParameters, global::ElevenLabs.Wan25PreviewVideoParameters, global::ElevenLabs.Wan26Parameters, global::ElevenLabs.LTXV2Parameters, global::ElevenLabs.LTXV2FastParameters, global::ElevenLabs.RunwayGen45Parameters, global::ElevenLabs.RunwayGen4ImageParameters, global::ElevenLabs.TestParameters, global::ElevenLabs.ElevenLabsTTSParameters, global::ElevenLabs.ElevenLabsSFXParameters, global::ElevenLabs.ElevenLabsMusicParameters, global::ElevenLabs.GeminiLLMParameters, global::ElevenLabs.ElevenLabsCompositionTemplateParameters, global::ElevenLabs.Kling26ProMotionControlTemplateParameters, global::ElevenLabs.KlingOmniEditVideoTemplateParameters, global::ElevenLabs.TopazImageUpscaleTemplateParameters, global::ElevenLabs.TopazVideoUpscaleTemplateParameters, global::ElevenLabs.BiRefNetBgRemovalTemplateParameters, global::ElevenLabs.SyncLipSyncTemplateParameters, global::ElevenLabs.VeedLipSyncTemplateParameters, global::ElevenLabs.VeedFabricTemplateParameters, global::ElevenLabs.BytedanceOmniHumanTemplateParameters, global::ElevenLabs.CreatifyAuroraTemplateParameters, global::ElevenLabs.LTXV2RetakeTemplateParameters, global::ElevenLabs.LTXAudioToVideoTemplateParameters, global::ElevenLabs.RunwayGen4TurboTemplateParameters, global::ElevenLabs.RunwayGen4AlephTemplateParameters, global::ElevenLabs.RunwayActTwoTemplateParameters, global::ElevenLabs.RunwayGen4ImageTurboTemplateParameters, object>))]
        public global::ElevenLabs.AnyOf<global::ElevenLabs.Veo3Parameters, global::ElevenLabs.Veo2Parameters, global::ElevenLabs.Veo2ExpParameters, global::ElevenLabs.Veo31Parameters, global::ElevenLabs.Veo31FastParameters, global::ElevenLabs.Veo31LiteParameters, global::ElevenLabs.GeminiImageParameters, global::ElevenLabs.GeminiImageProParameters, global::ElevenLabs.Gemini31FlashImageParameters, global::ElevenLabs.Imagen4FastParameters, global::ElevenLabs.Imagen4Parameters, global::ElevenLabs.Sora2Parameters, global::ElevenLabs.Sora2ProParameters, global::ElevenLabs.GPTImageParameters, global::ElevenLabs.GPTImage2Parameters, global::ElevenLabs.Kling25TurboParameters, global::ElevenLabs.Kling26ProParameters, global::ElevenLabs.KlingOmniVideoParameters, global::ElevenLabs.KlingOmniImageParameters, global::ElevenLabs.KlingO3ProParameters, global::ElevenLabs.Kling3ProParameters, global::ElevenLabs.Flux1KontextParameters, global::ElevenLabs.Flux2ProParameters, global::ElevenLabs.BytedanceSeedanceParameters, global::ElevenLabs.BytedanceSeedance15ProParameters, global::ElevenLabs.BytedanceSeedance2Parameters, global::ElevenLabs.BytedanceSeedance2FastParameters, global::ElevenLabs.BytedanceSeedream4Parameters, global::ElevenLabs.BytedanceSeedream45Parameters, global::ElevenLabs.BytedanceSeedream5LiteParameters, global::ElevenLabs.Wan25PreviewImageParameters, global::ElevenLabs.Wan25PreviewVideoParameters, global::ElevenLabs.Wan26Parameters, global::ElevenLabs.LTXV2Parameters, global::ElevenLabs.LTXV2FastParameters, global::ElevenLabs.RunwayGen45Parameters, global::ElevenLabs.RunwayGen4ImageParameters, global::ElevenLabs.TestParameters, global::ElevenLabs.ElevenLabsTTSParameters, global::ElevenLabs.ElevenLabsSFXParameters, global::ElevenLabs.ElevenLabsMusicParameters, global::ElevenLabs.GeminiLLMParameters, global::ElevenLabs.ElevenLabsCompositionTemplateParameters, global::ElevenLabs.Kling26ProMotionControlTemplateParameters, global::ElevenLabs.KlingOmniEditVideoTemplateParameters, global::ElevenLabs.TopazImageUpscaleTemplateParameters, global::ElevenLabs.TopazVideoUpscaleTemplateParameters, global::ElevenLabs.BiRefNetBgRemovalTemplateParameters, global::ElevenLabs.SyncLipSyncTemplateParameters, global::ElevenLabs.VeedLipSyncTemplateParameters, global::ElevenLabs.VeedFabricTemplateParameters, global::ElevenLabs.BytedanceOmniHumanTemplateParameters, global::ElevenLabs.CreatifyAuroraTemplateParameters, global::ElevenLabs.LTXV2RetakeTemplateParameters, global::ElevenLabs.LTXAudioToVideoTemplateParameters, global::ElevenLabs.RunwayGen4TurboTemplateParameters, global::ElevenLabs.RunwayGen4AlephTemplateParameters, global::ElevenLabs.RunwayActTwoTemplateParameters, global::ElevenLabs.RunwayGen4ImageTurboTemplateParameters, object>? ModelParameters { get; set; }

        /// <summary>
        /// ID of the currently active/selected generation output for this node. When set, the UI displays this generation as the active output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_generation_id")]
        public string? ActiveGenerationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationNode" /> class.
        /// </summary>
        /// <param name="id">
        /// Globally unique identifier for this node (must be unique across all templates). Clients must generate a random alphanumeric ID with sufficient entropy to avoid collisions.
        /// </param>
        /// <param name="label">
        /// Label for the node, displayed in the UI.
        /// </param>
        /// <param name="templateId">
        /// ID of the template this node belongs to.
        /// </param>
        /// <param name="position">
        /// Position of the node on the canvas.
        /// </param>
        /// <param name="modelId">
        /// The model to use (e.g., 'gemini-2.5-flash-image', 'veo-3.1-generate-001').
        /// </param>
        /// <param name="modifiedBy">
        /// User ID of the person who last modified this node.
        /// </param>
        /// <param name="modifiedAtUtc">
        /// When this node was last modified.
        /// </param>
        /// <param name="type">
        /// Default Value: generation
        /// </param>
        /// <param name="prompt">
        /// The prompt for this node. Can be a literal string or a reference to another node's output.
        /// </param>
        /// <param name="displayPrompt">
        /// Rich text representation of the prompt preserving formatting and inline components.
        /// </param>
        /// <param name="modelParameters">
        /// Model-specific parameters.
        /// </param>
        /// <param name="activeGenerationId">
        /// ID of the currently active/selected generation output for this node. When set, the UI displays this generation as the active output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationNode(
            string id,
            string label,
            string templateId,
            global::ElevenLabs.NodePosition position,
            global::ElevenLabs.ModelID modelId,
            string? modifiedBy,
            global::System.DateTime? modifiedAtUtc,
            string? type,
            global::ElevenLabs.AnyOf<string, global::ElevenLabs.ReferenceText, object>? prompt,
            object? displayPrompt,
            global::ElevenLabs.AnyOf<global::ElevenLabs.Veo3Parameters, global::ElevenLabs.Veo2Parameters, global::ElevenLabs.Veo2ExpParameters, global::ElevenLabs.Veo31Parameters, global::ElevenLabs.Veo31FastParameters, global::ElevenLabs.Veo31LiteParameters, global::ElevenLabs.GeminiImageParameters, global::ElevenLabs.GeminiImageProParameters, global::ElevenLabs.Gemini31FlashImageParameters, global::ElevenLabs.Imagen4FastParameters, global::ElevenLabs.Imagen4Parameters, global::ElevenLabs.Sora2Parameters, global::ElevenLabs.Sora2ProParameters, global::ElevenLabs.GPTImageParameters, global::ElevenLabs.GPTImage2Parameters, global::ElevenLabs.Kling25TurboParameters, global::ElevenLabs.Kling26ProParameters, global::ElevenLabs.KlingOmniVideoParameters, global::ElevenLabs.KlingOmniImageParameters, global::ElevenLabs.KlingO3ProParameters, global::ElevenLabs.Kling3ProParameters, global::ElevenLabs.Flux1KontextParameters, global::ElevenLabs.Flux2ProParameters, global::ElevenLabs.BytedanceSeedanceParameters, global::ElevenLabs.BytedanceSeedance15ProParameters, global::ElevenLabs.BytedanceSeedance2Parameters, global::ElevenLabs.BytedanceSeedance2FastParameters, global::ElevenLabs.BytedanceSeedream4Parameters, global::ElevenLabs.BytedanceSeedream45Parameters, global::ElevenLabs.BytedanceSeedream5LiteParameters, global::ElevenLabs.Wan25PreviewImageParameters, global::ElevenLabs.Wan25PreviewVideoParameters, global::ElevenLabs.Wan26Parameters, global::ElevenLabs.LTXV2Parameters, global::ElevenLabs.LTXV2FastParameters, global::ElevenLabs.RunwayGen45Parameters, global::ElevenLabs.RunwayGen4ImageParameters, global::ElevenLabs.TestParameters, global::ElevenLabs.ElevenLabsTTSParameters, global::ElevenLabs.ElevenLabsSFXParameters, global::ElevenLabs.ElevenLabsMusicParameters, global::ElevenLabs.GeminiLLMParameters, global::ElevenLabs.ElevenLabsCompositionTemplateParameters, global::ElevenLabs.Kling26ProMotionControlTemplateParameters, global::ElevenLabs.KlingOmniEditVideoTemplateParameters, global::ElevenLabs.TopazImageUpscaleTemplateParameters, global::ElevenLabs.TopazVideoUpscaleTemplateParameters, global::ElevenLabs.BiRefNetBgRemovalTemplateParameters, global::ElevenLabs.SyncLipSyncTemplateParameters, global::ElevenLabs.VeedLipSyncTemplateParameters, global::ElevenLabs.VeedFabricTemplateParameters, global::ElevenLabs.BytedanceOmniHumanTemplateParameters, global::ElevenLabs.CreatifyAuroraTemplateParameters, global::ElevenLabs.LTXV2RetakeTemplateParameters, global::ElevenLabs.LTXAudioToVideoTemplateParameters, global::ElevenLabs.RunwayGen4TurboTemplateParameters, global::ElevenLabs.RunwayGen4AlephTemplateParameters, global::ElevenLabs.RunwayActTwoTemplateParameters, global::ElevenLabs.RunwayGen4ImageTurboTemplateParameters, object>? modelParameters,
            string? activeGenerationId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.ModifiedBy = modifiedBy;
            this.ModifiedAtUtc = modifiedAtUtc;
            this.Type = type;
            this.ModelId = modelId;
            this.Prompt = prompt;
            this.DisplayPrompt = displayPrompt;
            this.ModelParameters = modelParameters;
            this.ActiveGenerationId = activeGenerationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationNode" /> class.
        /// </summary>
        public GenerationNode()
        {
        }
    }
}