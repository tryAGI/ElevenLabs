
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GuardrailsResult
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered")]
        public bool? Triggered { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsResult" /> class.
        /// </summary>
        /// <param name="triggered">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GuardrailsResult(
            bool? triggered)
        {
            this.Triggered = triggered;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardrailsResult" /> class.
        /// </summary>
        public GuardrailsResult()
        {
        }

    }
}