
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MusicFinetunePageResponseModel
    {
        /// <summary>
        /// The finetunes in this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetunes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.MusicFinetuneResponseModel> Finetunes { get; set; }

        /// <summary>
        /// Cursor to pass as `cursor` to fetch the next page; `null` when there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether more finetunes are available beyond this page.
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
        /// Initializes a new instance of the <see cref="MusicFinetunePageResponseModel" /> class.
        /// </summary>
        /// <param name="finetunes">
        /// The finetunes in this page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more finetunes are available beyond this page.
        /// </param>
        /// <param name="nextCursor">
        /// Cursor to pass as `cursor` to fetch the next page; `null` when there are no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MusicFinetunePageResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.MusicFinetuneResponseModel> finetunes,
            bool hasMore,
            string? nextCursor)
        {
            this.Finetunes = finetunes ?? throw new global::System.ArgumentNullException(nameof(finetunes));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MusicFinetunePageResponseModel" /> class.
        /// </summary>
        public MusicFinetunePageResponseModel()
        {
        }

    }
}