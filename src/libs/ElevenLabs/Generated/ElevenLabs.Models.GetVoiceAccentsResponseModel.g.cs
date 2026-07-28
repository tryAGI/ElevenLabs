
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"accents":[{"accent":"american","code":"en-american","language":"en","name":"American"}]}
    /// </summary>
    public sealed partial class GetVoiceAccentsResponseModel
    {
        /// <summary>
        /// A list of available voice accents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.VoiceAccentResponseModel> Accents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoiceAccentsResponseModel" /> class.
        /// </summary>
        /// <param name="accents">
        /// A list of available voice accents.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVoiceAccentsResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.VoiceAccentResponseModel> accents)
        {
            this.Accents = accents ?? throw new global::System.ArgumentNullException(nameof(accents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoiceAccentsResponseModel" /> class.
        /// </summary>
        public GetVoiceAccentsResponseModel()
        {
        }

    }
}