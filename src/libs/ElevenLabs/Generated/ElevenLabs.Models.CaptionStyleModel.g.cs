
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionStyleModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizontal_placement")]
        public global::ElevenLabs.CaptionStyleHorizontalPlacementModel? HorizontalPlacement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical_placement")]
        public global::ElevenLabs.CaptionStyleVerticalPlacementModel? VerticalPlacement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width_pct")]
        public double? WidthPct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_scale")]
        public double? TextScale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_color")]
        public string? TextColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_align")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CaptionStyleModelTextAlignJsonConverter))]
        public global::ElevenLabs.CaptionStyleModelTextAlign? TextAlign { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_enabled")]
        public bool? BackgroundEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_color")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background_opacity")]
        public double? BackgroundOpacity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_highlights_enabled")]
        public bool? WordHighlightsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_highlights_background_color")]
        public string? WordHighlightsBackgroundColor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_highlights_opacity")]
        public double? WordHighlightsOpacity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleModel" /> class.
        /// </summary>
        /// <param name="horizontalPlacement"></param>
        /// <param name="verticalPlacement"></param>
        /// <param name="widthPct"></param>
        /// <param name="textScale"></param>
        /// <param name="textColor"></param>
        /// <param name="textAlign"></param>
        /// <param name="backgroundEnabled"></param>
        /// <param name="backgroundColor"></param>
        /// <param name="backgroundOpacity"></param>
        /// <param name="wordHighlightsEnabled"></param>
        /// <param name="wordHighlightsBackgroundColor"></param>
        /// <param name="wordHighlightsOpacity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptionStyleModel(
            global::ElevenLabs.CaptionStyleHorizontalPlacementModel? horizontalPlacement,
            global::ElevenLabs.CaptionStyleVerticalPlacementModel? verticalPlacement,
            double? widthPct,
            double? textScale,
            string? textColor,
            global::ElevenLabs.CaptionStyleModelTextAlign? textAlign,
            bool? backgroundEnabled,
            string? backgroundColor,
            double? backgroundOpacity,
            bool? wordHighlightsEnabled,
            string? wordHighlightsBackgroundColor,
            double? wordHighlightsOpacity)
        {
            this.HorizontalPlacement = horizontalPlacement;
            this.VerticalPlacement = verticalPlacement;
            this.WidthPct = widthPct;
            this.TextScale = textScale;
            this.TextColor = textColor;
            this.TextAlign = textAlign;
            this.BackgroundEnabled = backgroundEnabled;
            this.BackgroundColor = backgroundColor;
            this.BackgroundOpacity = backgroundOpacity;
            this.WordHighlightsEnabled = wordHighlightsEnabled;
            this.WordHighlightsBackgroundColor = wordHighlightsBackgroundColor;
            this.WordHighlightsOpacity = wordHighlightsOpacity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleModel" /> class.
        /// </summary>
        public CaptionStyleModel()
        {
        }
    }
}