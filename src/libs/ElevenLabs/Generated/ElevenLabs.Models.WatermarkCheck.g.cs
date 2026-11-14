
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WatermarkCheck
    {
        /// <summary>
        /// True when an ElevenLabs watermark was found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_detected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDetected { get; set; }

        /// <summary>
        /// Matched generation record. Null when none matched.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::ElevenLabs.WatermarkDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkCheck" /> class.
        /// </summary>
        /// <param name="isDetected">
        /// True when an ElevenLabs watermark was found.
        /// </param>
        /// <param name="details">
        /// Matched generation record. Null when none matched.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WatermarkCheck(
            bool isDetected,
            global::ElevenLabs.WatermarkDetails? details)
        {
            this.IsDetected = isDetected;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkCheck" /> class.
        /// </summary>
        public WatermarkCheck()
        {
        }

    }
}