
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A newly queued media generation; fetch the GET endpoint for the output.<br/>
    /// Example: {"id":"JWr5N6X9ZTqf8jD2LmQb","status":"pending"}
    /// </summary>
    public sealed partial class MediaGenerationCreateResponse
    {
        /// <summary>
        /// The unique identifier of the generation. Pass it to the corresponding GET endpoint to retrieve the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A newly created generation is always `pending`.
        /// </summary>
        /// <default>"pending"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "pending";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaGenerationCreateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the generation. Pass it to the corresponding GET endpoint to retrieve the output.
        /// </param>
        /// <param name="status">
        /// A newly created generation is always `pending`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MediaGenerationCreateResponse(
            string id,
            string status = "pending")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaGenerationCreateResponse" /> class.
        /// </summary>
        public MediaGenerationCreateResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="MediaGenerationCreateResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static MediaGenerationCreateResponse FromId(string id)
        {
            return new MediaGenerationCreateResponse
            {
                Id = id,
            };
        }

    }
}