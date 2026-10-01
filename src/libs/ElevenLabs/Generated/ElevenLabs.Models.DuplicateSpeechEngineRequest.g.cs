
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DuplicateSpeechEngineRequest
    {
        /// <summary>
        /// Name for the duplicated speech engine. Defaults to the source name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateSpeechEngineRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the duplicated speech engine. Defaults to the source name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DuplicateSpeechEngineRequest(
            string? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateSpeechEngineRequest" /> class.
        /// </summary>
        public DuplicateSpeechEngineRequest()
        {
        }

    }
}