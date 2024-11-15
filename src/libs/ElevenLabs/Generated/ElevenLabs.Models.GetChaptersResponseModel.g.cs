
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChaptersResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel> Chapters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChaptersResponseModel" /> class.
        /// </summary>
        /// <param name="chapters"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetChaptersResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.ChapterResponseModel> chapters)
        {
            this.Chapters = chapters ?? throw new global::System.ArgumentNullException(nameof(chapters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChaptersResponseModel" /> class.
        /// </summary>
        public GetChaptersResponseModel()
        {
        }
    }
}