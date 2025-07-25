
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionStyleHorizontalPlacementModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("align")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CaptionStyleHorizontalPlacementModelAlignJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign Align { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("translate_pct")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TranslatePct { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleHorizontalPlacementModel" /> class.
        /// </summary>
        /// <param name="align"></param>
        /// <param name="translatePct"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptionStyleHorizontalPlacementModel(
            global::ElevenLabs.CaptionStyleHorizontalPlacementModelAlign align,
            double translatePct)
        {
            this.Align = align;
            this.TranslatePct = translatePct;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleHorizontalPlacementModel" /> class.
        /// </summary>
        public CaptionStyleHorizontalPlacementModel()
        {
        }
    }
}