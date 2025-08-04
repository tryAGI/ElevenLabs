
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CaptionStyleCharacterAnimationModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enter_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelEnterTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType EnterType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exit_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.CaptionStyleCharacterAnimationModelExitTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType ExitType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleCharacterAnimationModel" /> class.
        /// </summary>
        /// <param name="enterType"></param>
        /// <param name="exitType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CaptionStyleCharacterAnimationModel(
            global::ElevenLabs.CaptionStyleCharacterAnimationModelEnterType enterType,
            global::ElevenLabs.CaptionStyleCharacterAnimationModelExitType exitType)
        {
            this.EnterType = enterType;
            this.ExitType = exitType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptionStyleCharacterAnimationModel" /> class.
        /// </summary>
        public CaptionStyleCharacterAnimationModel()
        {
        }
    }
}