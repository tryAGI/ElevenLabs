
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Parameters for the test provider - minimal, just for testing.
    /// </summary>
    public sealed partial class TestParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? Images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::ElevenLabs.ReferenceVideo? Video { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public bool? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_mpx")]
        public double? EstimatedMpx { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_duration")]
        public double? EstimatedDuration { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charge_from_reference_sizes")]
        public bool? ChargeFromReferenceSizes { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charge_from_reference_durations")]
        public bool? ChargeFromReferenceDurations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestParameters" /> class.
        /// </summary>
        /// <param name="images"></param>
        /// <param name="video"></param>
        /// <param name="error">
        /// Default Value: false
        /// </param>
        /// <param name="estimatedMpx"></param>
        /// <param name="estimatedDuration"></param>
        /// <param name="chargeFromReferenceSizes">
        /// Default Value: false
        /// </param>
        /// <param name="chargeFromReferenceDurations">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestParameters(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReferenceImage>? images,
            global::ElevenLabs.ReferenceVideo? video,
            bool? error,
            double? estimatedMpx,
            double? estimatedDuration,
            bool? chargeFromReferenceSizes,
            bool? chargeFromReferenceDurations)
        {
            this.Images = images;
            this.Video = video;
            this.Error = error;
            this.EstimatedMpx = estimatedMpx;
            this.EstimatedDuration = estimatedDuration;
            this.ChargeFromReferenceSizes = chargeFromReferenceSizes;
            this.ChargeFromReferenceDurations = chargeFromReferenceDurations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestParameters" /> class.
        /// </summary>
        public TestParameters()
        {
        }
    }
}