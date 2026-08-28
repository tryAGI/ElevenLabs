
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InternalSamplingConfigResponseModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("focus")]
        public double? Focus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        public double? Similarity { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalSamplingConfigResponseModel" /> class.
        /// </summary>
        /// <param name="focus"></param>
        /// <param name="similarity"></param>
        /// <param name="stability"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InternalSamplingConfigResponseModel(
            double? focus,
            double? similarity,
            double? stability)
        {
            this.Focus = focus;
            this.Similarity = similarity;
            this.Stability = stability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalSamplingConfigResponseModel" /> class.
        /// </summary>
        public InternalSamplingConfigResponseModel()
        {
        }

    }
}