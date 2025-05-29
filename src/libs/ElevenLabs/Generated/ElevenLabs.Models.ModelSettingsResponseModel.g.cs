
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelSettingsResponseModel
    {
        /// <summary>
        /// Determines how stable the voice is and the randomness between each generation. Lower values introduce broader emotional range for the voice. Higher values can result in a monotonous voice with limited emotion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// Determines how closely the AI should adhere to the original voice when attempting to replicate it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_boost")]
        public double? SimilarityBoost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="stability">
        /// Determines how stable the voice is and the randomness between each generation. Lower values introduce broader emotional range for the voice. Higher values can result in a monotonous voice with limited emotion.
        /// </param>
        /// <param name="similarityBoost">
        /// Determines how closely the AI should adhere to the original voice when attempting to replicate it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelSettingsResponseModel(
            double? stability,
            double? similarityBoost)
        {
            this.Stability = stability;
            this.SimilarityBoost = similarityBoost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSettingsResponseModel" /> class.
        /// </summary>
        public ModelSettingsResponseModel()
        {
        }
    }
}