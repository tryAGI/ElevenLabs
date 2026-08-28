
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OTelTracePayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceSpans")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.OTelResourceSpans> ResourceSpans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTelTracePayload" /> class.
        /// </summary>
        /// <param name="resourceSpans"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OTelTracePayload(
            global::System.Collections.Generic.IList<global::ElevenLabs.OTelResourceSpans> resourceSpans)
        {
            this.ResourceSpans = resourceSpans ?? throw new global::System.ArgumentNullException(nameof(resourceSpans));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTelTracePayload" /> class.
        /// </summary>
        public OTelTracePayload()
        {
        }

    }
}