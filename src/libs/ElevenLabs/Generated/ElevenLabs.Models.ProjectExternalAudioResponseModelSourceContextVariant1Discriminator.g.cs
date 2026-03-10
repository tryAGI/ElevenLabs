
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectExternalAudioResponseModelSourceContextVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceTypeJsonConverter))]
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? SourceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExternalAudioResponseModelSourceContextVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="sourceType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectExternalAudioResponseModelSourceContextVariant1Discriminator(
            global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? sourceType)
        {
            this.SourceType = sourceType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectExternalAudioResponseModelSourceContextVariant1Discriminator" /> class.
        /// </summary>
        public ProjectExternalAudioResponseModelSourceContextVariant1Discriminator()
        {
        }
    }
}