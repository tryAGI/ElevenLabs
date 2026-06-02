
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwayActTwoParameters
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_control")]
        public bool? BodyControl { get; set; }

        /// <summary>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expression_intensity")]
        public int? ExpressionIntensity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceImage Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceVideo Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayActTwoParameters" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="video"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="bodyControl">
        /// Default Value: false
        /// </param>
        /// <param name="expressionIntensity">
        /// Default Value: 3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwayActTwoParameters(
            global::ElevenLabs.ReferenceImage image,
            global::ElevenLabs.ReferenceVideo video,
            string? aspectRatio,
            bool? bodyControl,
            int? expressionIntensity)
        {
            this.AspectRatio = aspectRatio;
            this.BodyControl = bodyControl;
            this.ExpressionIntensity = expressionIntensity;
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayActTwoParameters" /> class.
        /// </summary>
        public RunwayActTwoParameters()
        {
        }

    }
}