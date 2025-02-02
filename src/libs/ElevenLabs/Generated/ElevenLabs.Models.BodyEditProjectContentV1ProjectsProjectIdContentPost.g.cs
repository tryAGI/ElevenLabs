
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyEditProjectContentV1ProjectsProjectIdContentPost
    {
        /// <summary>
        /// An optional URL from which we will extract content to initialize the project. If this is set, 'from_url' must be null. If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_url")]
        public string? FromUrl { get; set; }

        /// <summary>
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_document")]
        public byte[]? FromDocument { get; set; }

        /// <summary>
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_documentname")]
        public string? FromDocumentname { get; set; }

        /// <summary>
        /// Whether to auto convert the project to audio or not.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_convert")]
        public bool? AutoConvert { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditProjectContentV1ProjectsProjectIdContentPost" /> class.
        /// </summary>
        /// <param name="fromUrl">
        /// An optional URL from which we will extract content to initialize the project. If this is set, 'from_url' must be null. If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </param>
        /// <param name="fromDocument">
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </param>
        /// <param name="fromDocumentname">
        /// An optional .epub, .pdf, .txt or similar file can be provided. If provided, we will initialize the project with its content. If this is set, 'from_url' must be null.  If neither 'from_url' or 'from_document' are provided we will initialize the project as blank.
        /// </param>
        /// <param name="autoConvert">
        /// Whether to auto convert the project to audio or not.<br/>
        /// Default Value: false
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BodyEditProjectContentV1ProjectsProjectIdContentPost(
            string? fromUrl,
            byte[]? fromDocument,
            string? fromDocumentname,
            bool? autoConvert)
        {
            this.FromUrl = fromUrl;
            this.FromDocument = fromDocument;
            this.FromDocumentname = fromDocumentname;
            this.AutoConvert = autoConvert;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyEditProjectContentV1ProjectsProjectIdContentPost" /> class.
        /// </summary>
        public BodyEditProjectContentV1ProjectsProjectIdContentPost()
        {
        }
    }
}