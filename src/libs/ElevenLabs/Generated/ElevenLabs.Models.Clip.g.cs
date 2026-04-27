
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Clip
    {
        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gap_before")]
        public double? GapBefore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeline_start")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? TimelineStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_in")]
        public double? TrimIn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trim_out")]
        public double? TrimOut { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ReferenceAudio, global::ElevenLabs.ReferenceVideo>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnyOf<global::ElevenLabs.ReferenceAudio, global::ElevenLabs.ReferenceVideo> Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Clip" /> class.
        /// </summary>
        /// <param name="modality"></param>
        /// <param name="source"></param>
        /// <param name="gapBefore">
        /// Default Value: 0F
        /// </param>
        /// <param name="trimIn"></param>
        /// <param name="trimOut"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Clip(
            global::ElevenLabs.ContentModality modality,
            global::ElevenLabs.AnyOf<global::ElevenLabs.ReferenceAudio, global::ElevenLabs.ReferenceVideo> source,
            double? gapBefore,
            double? trimIn,
            double? trimOut)
        {
            this.GapBefore = gapBefore;
            this.TrimIn = trimIn;
            this.TrimOut = trimOut;
            this.Modality = modality;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Clip" /> class.
        /// </summary>
        public Clip()
        {
        }
    }
}