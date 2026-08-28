
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OTelScopeSpans
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.OTelScope Scope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.OTelSpan> Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTelScopeSpans" /> class.
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="spans"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OTelScopeSpans(
            global::ElevenLabs.OTelScope scope,
            global::System.Collections.Generic.IList<global::ElevenLabs.OTelSpan> spans)
        {
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.Spans = spans ?? throw new global::System.ArgumentNullException(nameof(spans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTelScopeSpans" /> class.
        /// </summary>
        public OTelScopeSpans()
        {
        }

    }
}