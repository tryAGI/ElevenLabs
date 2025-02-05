
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingMediaMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMediaMetadata" /> class.
        /// </summary>
        /// <param name="contentType"></param>
        /// <param name="duration"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DubbingMediaMetadata(
            string contentType,
            double duration)
        {
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMediaMetadata" /> class.
        /// </summary>
        public DubbingMediaMetadata()
        {
        }
    }
}