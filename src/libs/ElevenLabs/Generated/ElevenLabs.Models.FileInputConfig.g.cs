
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileInputConfig
    {
        /// <summary>
        /// When enabled, users may attach images or PDFs in chat when the LLM supports multimodal input.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Number of most-recent files kept in memory during a conversation. Older files are summarized and their bytes freed.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_files_in_memory")]
        public long? MaxFilesInMemory { get; set; }

        /// <summary>
        /// Total files a user can upload in one conversation. Uploads are billed per file. Use -1 for no limit, or a value &gt;= max_files_in_memory.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_files_per_conversation")]
        public int? MaxFilesPerConversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileInputConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When enabled, users may attach images or PDFs in chat when the LLM supports multimodal input.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="maxFilesInMemory">
        /// Number of most-recent files kept in memory during a conversation. Older files are summarized and their bytes freed.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="maxFilesPerConversation">
        /// Total files a user can upload in one conversation. Uploads are billed per file. Use -1 for no limit, or a value &gt;= max_files_in_memory.<br/>
        /// Default Value: 10
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileInputConfig(
            bool? enabled,
            long? maxFilesInMemory,
            int? maxFilesPerConversation)
        {
            this.Enabled = enabled;
            this.MaxFilesInMemory = maxFilesInMemory;
            this.MaxFilesPerConversation = maxFilesPerConversation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileInputConfig" /> class.
        /// </summary>
        public FileInputConfig()
        {
        }

    }
}