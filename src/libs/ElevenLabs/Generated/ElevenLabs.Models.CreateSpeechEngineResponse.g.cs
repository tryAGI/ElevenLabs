
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"speech_engine_id":"seng_3701k3ttaq12ewp8b7qv5rfyszkz"}
    /// </summary>
    public sealed partial class CreateSpeechEngineResponse
    {
        /// <summary>
        /// The speech engine resource ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speech_engine_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpeechEngineId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechEngineResponse" /> class.
        /// </summary>
        /// <param name="speechEngineId">
        /// The speech engine resource ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpeechEngineResponse(
            string speechEngineId)
        {
            this.SpeechEngineId = speechEngineId ?? throw new global::System.ArgumentNullException(nameof(speechEngineId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpeechEngineResponse" /> class.
        /// </summary>
        public CreateSpeechEngineResponse()
        {
        }

    }
}