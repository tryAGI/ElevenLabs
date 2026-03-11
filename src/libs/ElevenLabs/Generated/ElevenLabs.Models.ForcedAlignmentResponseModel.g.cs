
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Model representing the response from the aligner service.
    /// </summary>
    public sealed partial class ForcedAlignmentResponseModel
    {
        /// <summary>
        /// List of characters with their timing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentCharacterResponseModel> Characters { get; set; } = default!;

        /// <summary>
        /// List of words with their timing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentWordResponseModel> Words { get; set; } = default!;

        /// <summary>
        /// The average alignment loss/confidence score for the entire transcript, calculated from all characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loss")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double Loss { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAlignmentResponseModel" /> class.
        /// </summary>
        /// <param name="characters">
        /// List of characters with their timing information.
        /// </param>
        /// <param name="words">
        /// List of words with their timing information.
        /// </param>
        /// <param name="loss">
        /// The average alignment loss/confidence score for the entire transcript, calculated from all characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ForcedAlignmentResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentCharacterResponseModel> characters,
            global::System.Collections.Generic.IList<global::ElevenLabs.ForcedAlignmentWordResponseModel> words,
            double loss)
        {
            this.Characters = characters ?? throw new global::System.ArgumentNullException(nameof(characters));
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.Loss = loss;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForcedAlignmentResponseModel" /> class.
        /// </summary>
        public ForcedAlignmentResponseModel()
        {
        }
    }
}