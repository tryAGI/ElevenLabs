
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SampleResponseModel
    {
        /// <summary>
        /// The ID of the sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SampleId { get; set; }

        /// <summary>
        /// The name of the sample file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileName { get; set; }

        /// <summary>
        /// The MIME type of the sample file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// The size of the sample file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SizeBytes { get; set; }

        /// <summary>
        /// The hash of the sample file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleResponseModel" /> class.
        /// </summary>
        /// <param name="sampleId">
        /// The ID of the sample.
        /// </param>
        /// <param name="fileName">
        /// The name of the sample file.
        /// </param>
        /// <param name="mimeType">
        /// The MIME type of the sample file.
        /// </param>
        /// <param name="sizeBytes">
        /// The size of the sample file in bytes.
        /// </param>
        /// <param name="hash">
        /// The hash of the sample file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SampleResponseModel(
            string sampleId,
            string fileName,
            string mimeType,
            int sizeBytes,
            string hash)
        {
            this.SampleId = sampleId ?? throw new global::System.ArgumentNullException(nameof(sampleId));
            this.FileName = fileName ?? throw new global::System.ArgumentNullException(nameof(fileName));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.SizeBytes = sizeBytes;
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SampleResponseModel" /> class.
        /// </summary>
        public SampleResponseModel()
        {
        }
    }
}