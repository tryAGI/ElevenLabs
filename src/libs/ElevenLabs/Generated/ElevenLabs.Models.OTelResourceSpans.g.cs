
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OTelResourceSpans
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.OTelResource Resource { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeSpans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.OTelScopeSpans> ScopeSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTelResourceSpans" /> class.
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="scopeSpans"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OTelResourceSpans(
            global::ElevenLabs.OTelResource resource,
            global::System.Collections.Generic.IList<global::ElevenLabs.OTelScopeSpans> scopeSpans)
        {
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.ScopeSpans = scopeSpans ?? throw new global::System.ArgumentNullException(nameof(scopeSpans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTelResourceSpans" /> class.
        /// </summary>
        public OTelResourceSpans()
        {
        }

    }
}