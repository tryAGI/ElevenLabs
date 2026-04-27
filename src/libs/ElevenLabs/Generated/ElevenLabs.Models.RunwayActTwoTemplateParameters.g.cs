
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RunwayActTwoTemplateParameters
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
        public global::ElevenLabs.ReferenceImage? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        public global::ElevenLabs.ReferenceVideo? Video { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayActTwoTemplateParameters" /> class.
        /// </summary>
        /// <param name="aspectRatio"></param>
        /// <param name="bodyControl">
        /// Default Value: false
        /// </param>
        /// <param name="expressionIntensity">
        /// Default Value: 3
        /// </param>
        /// <param name="image"></param>
        /// <param name="video"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunwayActTwoTemplateParameters(
            string? aspectRatio,
            bool? bodyControl,
            int? expressionIntensity,
            global::ElevenLabs.ReferenceImage? image,
            global::ElevenLabs.ReferenceVideo? video)
        {
            this.AspectRatio = aspectRatio;
            this.BodyControl = bodyControl;
            this.ExpressionIntensity = expressionIntensity;
            this.Image = image;
            this.Video = video;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunwayActTwoTemplateParameters" /> class.
        /// </summary>
        public RunwayActTwoTemplateParameters()
        {
        }
    }
}