
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Parameters for ElevenLabs Dubbing in Flows. Charged per source minute via Dubbing billing.
    /// </summary>
    public sealed partial class ElevenLabsDubbingParameters
    {
        /// <summary>
        /// Reference to the upstream audio or video source to dub.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ReferenceAudio Source { get; set; }

        /// <summary>
        /// Language code to dub the source media into.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_language_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetLanguageCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsDubbingParameters" /> class.
        /// </summary>
        /// <param name="source">
        /// Reference to the upstream audio or video source to dub.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Language code to dub the source media into.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ElevenLabsDubbingParameters(
            global::ElevenLabs.ReferenceAudio source,
            string targetLanguageCode)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.TargetLanguageCode = targetLanguageCode ?? throw new global::System.ArgumentNullException(nameof(targetLanguageCode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevenLabsDubbingParameters" /> class.
        /// </summary>
        public ElevenLabsDubbingParameters()
        {
        }

    }
}