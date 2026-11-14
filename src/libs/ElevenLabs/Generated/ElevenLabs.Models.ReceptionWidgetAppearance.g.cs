
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How the website widget looks. A null label follows the receptionist's language.
    /// </summary>
    public sealed partial class ReceptionWidgetAppearance
    {
        /// <summary>
        /// First color of the widget's orb gradient, as a hex color.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orb_color_1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbColor1 { get; set; }

        /// <summary>
        /// Second color of the widget's orb gradient, as a hex color.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orb_color_2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbColor2 { get; set; }

        /// <summary>
        /// Widget size, from the smallest ('tiny') to the largest ('full').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ReceptionWidgetAppearanceVariantJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReceptionWidgetAppearanceVariant Variant { get; set; }

        /// <summary>
        /// Where on the page the widget sits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ReceptionWidgetAppearancePlacementJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReceptionWidgetAppearancePlacement Placement { get; set; }

        /// <summary>
        /// Whether visitors can close the widget.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissible")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Dismissible { get; set; }

        /// <summary>
        /// Text shown on the widget; null uses the default for the receptionist's language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("main_label")]
        public string? MainLabel { get; set; }

        /// <summary>
        /// Text on the button that starts a call; null uses the default for the receptionist's language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_call")]
        public string? StartCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionWidgetAppearance" /> class.
        /// </summary>
        /// <param name="orbColor1">
        /// First color of the widget's orb gradient, as a hex color.
        /// </param>
        /// <param name="orbColor2">
        /// Second color of the widget's orb gradient, as a hex color.
        /// </param>
        /// <param name="variant">
        /// Widget size, from the smallest ('tiny') to the largest ('full').
        /// </param>
        /// <param name="placement">
        /// Where on the page the widget sits.
        /// </param>
        /// <param name="dismissible">
        /// Whether visitors can close the widget.
        /// </param>
        /// <param name="mainLabel">
        /// Text shown on the widget; null uses the default for the receptionist's language.
        /// </param>
        /// <param name="startCall">
        /// Text on the button that starts a call; null uses the default for the receptionist's language.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionWidgetAppearance(
            string orbColor1,
            string orbColor2,
            global::ElevenLabs.ReceptionWidgetAppearanceVariant variant,
            global::ElevenLabs.ReceptionWidgetAppearancePlacement placement,
            bool dismissible,
            string? mainLabel,
            string? startCall)
        {
            this.OrbColor1 = orbColor1 ?? throw new global::System.ArgumentNullException(nameof(orbColor1));
            this.OrbColor2 = orbColor2 ?? throw new global::System.ArgumentNullException(nameof(orbColor2));
            this.Variant = variant;
            this.Placement = placement;
            this.Dismissible = dismissible;
            this.MainLabel = mainLabel;
            this.StartCall = startCall;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionWidgetAppearance" /> class.
        /// </summary>
        public ReceptionWidgetAppearance()
        {
        }

    }
}