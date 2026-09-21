
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToDialogueSettingsResponseModel(
            double? stability,
            double? similarity)
        {
            this.Stability = stability;
            this.Similarity = similarity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToDialogueSettingsResponseModel" /> class.
        /// </summary>
        public ToDialogueSettingsResponseModel()
        {
        }

    }
}