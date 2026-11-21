
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodyCheckWatermarkV1ContentProvenanceWatermarkPost
    {
        /// <summary>
        /// Audio file to check for an embedded watermark.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Audio file to check for an embedded watermark.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Watermark decoder version. Defaults to latest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCheckWatermarkV1ContentProvenanceWatermarkPost" /> class.
        /// </summary>
        /// <param name="file">
        /// Audio file to check for an embedded watermark.
        /// </param>
        /// <param name="filename">
        /// Audio file to check for an embedded watermark.
        /// </param>
        /// <param name="version">
        /// Watermark decoder version. Defaults to latest.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCheckWatermarkV1ContentProvenanceWatermarkPost(
            byte[] file,
            string filename,
            string? version)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCheckWatermarkV1ContentProvenanceWatermarkPost" /> class.
        /// </summary>
        public BodyCheckWatermarkV1ContentProvenanceWatermarkPost()
        {
        }

    }
}