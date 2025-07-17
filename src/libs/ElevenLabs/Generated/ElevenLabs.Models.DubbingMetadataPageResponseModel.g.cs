
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingMetadataPageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dubs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.DubbingMetadataResponse> Dubs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataPageResponseModel" /> class.
        /// </summary>
        /// <param name="dubs"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingMetadataPageResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.DubbingMetadataResponse> dubs,
            string? nextCursor,
            bool hasMore)
        {
            this.Dubs = dubs ?? throw new global::System.ArgumentNullException(nameof(dubs));
            this.NextCursor = nextCursor ?? throw new global::System.ArgumentNullException(nameof(nextCursor));
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataPageResponseModel" /> class.
        /// </summary>
        public DubbingMetadataPageResponseModel()
        {
        }
    }
}