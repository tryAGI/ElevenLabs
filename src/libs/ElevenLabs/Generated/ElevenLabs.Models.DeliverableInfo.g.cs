
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"content_type":"video/mp4","name":"[fr][mp4] Item #cbaba1fe","signed_url":"https://storage.googleapis.com/example-bucket/deliverables/output_fr.mp4?X-Goog-Signature=...","version":1}
    /// </summary>
    public sealed partial class DeliverableInfo
    {
        /// <summary>
        /// A time-limited URL to download the delivered file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SignedUrl { get; set; }

        /// <summary>
        /// The MIME type of the delivered file (e.g. 'video/mp4').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// The name of the delivered file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The version number of the deliverable.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverableInfo" /> class.
        /// </summary>
        /// <param name="signedUrl">
        /// A time-limited URL to download the delivered file.
        /// </param>
        /// <param name="contentType">
        /// The MIME type of the delivered file (e.g. 'video/mp4').
        /// </param>
        /// <param name="name">
        /// The name of the delivered file.
        /// </param>
        /// <param name="version">
        /// The version number of the deliverable.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeliverableInfo(
            string signedUrl,
            string contentType,
            string name,
            int? version)
        {
            this.SignedUrl = signedUrl ?? throw new global::System.ArgumentNullException(nameof(signedUrl));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverableInfo" /> class.
        /// </summary>
        public DeliverableInfo()
        {
        }

    }
}