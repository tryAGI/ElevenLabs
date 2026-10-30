
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// How the website widget looks -- the only part of its config SMB exposes.<br/>
    /// Unlike the rest of a receptionist's settings this is not SMB data: it is<br/>
    /// written straight onto the ConvAI agent's ``platform_settings.widget``. The<br/>
    /// value types mirror ConvAI's ``WidgetConfig`` by hand because<br/>
    /// ``xi_reception`` must not depend on ``xi_agents``; they are the widget's<br/>
    /// public API, so they are stable.<br/>
    /// A ``None`` label means "no override", which keeps the widget following the<br/>
    /// agent's language instead of freezing today's translation into the config.
    /// </summary>
    public sealed partial class SMBWidgetAppearance
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orb_color_1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbColor1 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orb_color_2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrbColor2 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variant")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SMBWidgetAppearanceVariantJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SMBWidgetAppearanceVariant Variant { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SMBWidgetAppearancePlacementJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SMBWidgetAppearancePlacement Placement { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dismissible")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Dismissible { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("main_label")]
        public string? MainLabel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_call")]
        public string? StartCall { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBWidgetAppearance" /> class.
        /// </summary>
        /// <param name="orbColor1"></param>
        /// <param name="orbColor2"></param>
        /// <param name="variant"></param>
        /// <param name="placement"></param>
        /// <param name="dismissible"></param>
        /// <param name="mainLabel"></param>
        /// <param name="startCall"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBWidgetAppearance(
            string orbColor1,
            string orbColor2,
            global::ElevenLabs.SMBWidgetAppearanceVariant variant,
            global::ElevenLabs.SMBWidgetAppearancePlacement placement,
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
        /// Initializes a new instance of the <see cref="SMBWidgetAppearance" /> class.
        /// </summary>
        public SMBWidgetAppearance()
        {
        }

    }
}