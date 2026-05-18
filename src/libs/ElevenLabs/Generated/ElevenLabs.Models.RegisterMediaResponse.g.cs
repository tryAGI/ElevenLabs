
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"media_id":"prodmedia_01jgb2zd68f8f9tfvbb968wb8z"}
    /// </summary>
    public sealed partial class RegisterMediaResponse
    {
        /// <summary>
        /// The ID of the uploaded media file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MediaId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterMediaResponse" /> class.
        /// </summary>
        /// <param name="mediaId">
        /// The ID of the uploaded media file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterMediaResponse(
            string mediaId)
        {
            this.MediaId = mediaId ?? throw new global::System.ArgumentNullException(nameof(mediaId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterMediaResponse" /> class.
        /// </summary>
        public RegisterMediaResponse()
        {
        }

    }
}