
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateAnalysisItemAttachmentsRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnalysisItemSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnalysisItemSource Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attach")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemAttachmentDestination>? Attach { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detach")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemAttachmentDestination>? Detach { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnalysisItemAttachmentsRequestModel" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="attach"></param>
        /// <param name="detach"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAnalysisItemAttachmentsRequestModel(
            global::ElevenLabs.AnalysisItemSource source,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemAttachmentDestination>? attach,
            global::System.Collections.Generic.IList<global::ElevenLabs.AnalysisItemAttachmentDestination>? detach)
        {
            this.Source = source;
            this.Attach = attach;
            this.Detach = detach;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAnalysisItemAttachmentsRequestModel" /> class.
        /// </summary>
        public UpdateAnalysisItemAttachmentsRequestModel()
        {
        }

    }
}