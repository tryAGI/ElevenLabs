
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A media generation that has not finished yet.<br/>
    /// Example: {"id":"JWr5N6X9ZTqf8jD2LmQb","status":"generating"}
    /// </summary>
    public sealed partial class MediaGenerationInProgressResponse
    {
        /// <summary>
        /// The unique identifier of the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The lifecycle status of the generation. It ends at `completed` or `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.MediaGenerationInProgressResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.MediaGenerationInProgressResponseStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaGenerationInProgressResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the generation.
        /// </param>
        /// <param name="status">
        /// The lifecycle status of the generation. It ends at `completed` or `failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaGenerationInProgressResponse(
            string id,
            global::ElevenLabs.MediaGenerationInProgressResponseStatus status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaGenerationInProgressResponse" /> class.
        /// </summary>
        public MediaGenerationInProgressResponse()
        {
        }

    }
}