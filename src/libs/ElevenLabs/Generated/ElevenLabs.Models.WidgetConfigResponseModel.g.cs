
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WidgetConfigResponseModel
    {
        /// <summary>
        /// Default Value: full
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EmbedVariantJsonConverter))]
        public global::ElevenLabs.EmbedVariant? Variant { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>))]
        public global::ElevenLabs.AnyOf<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>? Avatar { get; set; }

        /// <summary>
        /// Default Value: none
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.WidgetFeedbackModeJsonConverter))]
        public global::ElevenLabs.WidgetFeedbackMode? FeedbackMode { get; set; }

        /// <summary>
        /// Default Value: #ffffff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_color")]
        public string? BgColor { get; set; }

        /// <summary>
        /// Default Value: #000000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_color")]
        public string? TextColor { get; set; }

        /// <summary>
        /// Default Value: #000000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btn_color")]
        public string? BtnColor { get; set; }

        /// <summary>
        /// Default Value: #ffffff
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btn_text_color")]
        public string? BtnTextColor { get; set; }

        /// <summary>
        /// Default Value: #e1e1e1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("border_color")]
        public string? BorderColor { get; set; }

        /// <summary>
        /// Default Value: #000000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("focus_color")]
        public string? FocusColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("border_radius")]
        public int? BorderRadius { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btn_radius")]
        public int? BtnRadius { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_text")]
        public string? ActionText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_call_text")]
        public string? StartCallText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_call_text")]
        public string? EndCallText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand_text")]
        public string? ExpandText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listening_text")]
        public string? ListeningText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaking_text")]
        public string? SpeakingText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shareable_page_text")]
        public string? ShareablePageText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_text")]
        public string? TermsText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_html")]
        public string? TermsHtml { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terms_key")]
        public string? TermsKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_language_overrides")]
        public global::System.Collections.Generic.IList<string>? SupportedLanguageOverrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigResponseModel" /> class.
        /// </summary>
        /// <param name="variant">
        /// Default Value: full
        /// </param>
        /// <param name="avatar"></param>
        /// <param name="feedbackMode">
        /// Default Value: none
        /// </param>
        /// <param name="bgColor">
        /// Default Value: #ffffff
        /// </param>
        /// <param name="textColor">
        /// Default Value: #000000
        /// </param>
        /// <param name="btnColor">
        /// Default Value: #000000
        /// </param>
        /// <param name="btnTextColor">
        /// Default Value: #ffffff
        /// </param>
        /// <param name="borderColor">
        /// Default Value: #e1e1e1
        /// </param>
        /// <param name="focusColor">
        /// Default Value: #000000
        /// </param>
        /// <param name="borderRadius"></param>
        /// <param name="btnRadius"></param>
        /// <param name="actionText"></param>
        /// <param name="startCallText"></param>
        /// <param name="endCallText"></param>
        /// <param name="expandText"></param>
        /// <param name="listeningText"></param>
        /// <param name="speakingText"></param>
        /// <param name="shareablePageText"></param>
        /// <param name="termsText"></param>
        /// <param name="termsHtml"></param>
        /// <param name="termsKey"></param>
        /// <param name="language"></param>
        /// <param name="supportedLanguageOverrides"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public WidgetConfigResponseModel(
            string language,
            global::ElevenLabs.EmbedVariant? variant,
            global::ElevenLabs.AnyOf<global::ElevenLabs.OrbAvatar, global::ElevenLabs.URLAvatar, global::ElevenLabs.ImageAvatar>? avatar,
            global::ElevenLabs.WidgetFeedbackMode? feedbackMode,
            string? bgColor,
            string? textColor,
            string? btnColor,
            string? btnTextColor,
            string? borderColor,
            string? focusColor,
            int? borderRadius,
            int? btnRadius,
            string? actionText,
            string? startCallText,
            string? endCallText,
            string? expandText,
            string? listeningText,
            string? speakingText,
            string? shareablePageText,
            string? termsText,
            string? termsHtml,
            string? termsKey,
            global::System.Collections.Generic.IList<string>? supportedLanguageOverrides)
        {
            this.Language = language ?? throw new global::System.ArgumentNullException(nameof(language));
            this.Variant = variant;
            this.Avatar = avatar;
            this.FeedbackMode = feedbackMode;
            this.BgColor = bgColor;
            this.TextColor = textColor;
            this.BtnColor = btnColor;
            this.BtnTextColor = btnTextColor;
            this.BorderColor = borderColor;
            this.FocusColor = focusColor;
            this.BorderRadius = borderRadius;
            this.BtnRadius = btnRadius;
            this.ActionText = actionText;
            this.StartCallText = startCallText;
            this.EndCallText = endCallText;
            this.ExpandText = expandText;
            this.ListeningText = listeningText;
            this.SpeakingText = speakingText;
            this.ShareablePageText = shareablePageText;
            this.TermsText = termsText;
            this.TermsHtml = termsHtml;
            this.TermsKey = termsKey;
            this.SupportedLanguageOverrides = supportedLanguageOverrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetConfigResponseModel" /> class.
        /// </summary>
        public WidgetConfigResponseModel()
        {
        }
    }
}