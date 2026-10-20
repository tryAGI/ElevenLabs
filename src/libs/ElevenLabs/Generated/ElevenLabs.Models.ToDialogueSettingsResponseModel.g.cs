
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"stability":0.5}
    /// </summary>
    public sealed partial class ToDialogueSettingsResponseModel
    {
        /// <summary>
        /// Determines how stable the voice is and the randomness between each generation. Lower values introduce broader emotional range for the voice. Higher values can result in a monotonous voice with limited emotion.<br/>
        /// Default Value: 0.5F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stability")]
        public double? Stability { get; set; }

        /// <summary>
        /// Determines how strongly the model is guided while generating. Higher values make the model adhere more closely to the voice, at the cost of variation. Not supported by every model.<br/>
        /// Default Value: 0.75F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity")]
        public double? Similarity { get; set; }

        /// <summary>
        /// Controls how closely the voice matches the professional voice clone samples, from 0 (low) to 1 (high). We recommend 0 for most use cases. Increase this value only if you experience issues with the default settings. Only applies to professional voice clones fine-tuned for the selected v4 model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clone_strength")]
        public double? CloneStrength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToDialogueSettingsResponseModel" /> class.
        /// </summary>
        /// <param name="stability">
        /// Determines how stable the voice is and the randomness between each generation. Lower values introduce broader emotional range for the voice. Higher values can result in a monotonous voice with limited emotion.<br/>
        /// Default Value: 0.5F
        /// </param>
        /// <param name="similarity">
        /// Determines how strongly the model is guided while generating. Higher values make the model adhere more closely to the voice, at the cost of variation. Not supported by every model.<br/>
        /// Default Value: 0.75F
        /// </param>
        /// <param name="cloneStrength">
        /// Controls how closely the voice matches the professional voice clone samples, from 0 (low) to 1 (high). We recommend 0 for most use cases. Increase this value only if you experience issues with the default settings. Only applies to professional voice clones fine-tuned for the selected v4 model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToDialogueSettingsResponseModel(
            double? stability,
            double? similarity,
            double? cloneStrength)
        {
            this.Stability = stability;
            this.Similarity = similarity;
            this.CloneStrength = cloneStrength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToDialogueSettingsResponseModel" /> class.
        /// </summary>
        public ToDialogueSettingsResponseModel()
        {
        }

    }
}