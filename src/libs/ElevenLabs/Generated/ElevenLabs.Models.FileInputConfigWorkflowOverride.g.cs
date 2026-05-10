
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FileInputConfigWorkflowOverride
    {
        /// <summary>
        /// When enabled, users may attach images or PDFs in chat when the LLM supports multimodal input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Maximum number of files that can be uploaded per conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_files_per_conversation")]
        public int? MaxFilesPerConversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileInputConfigWorkflowOverride" /> class.
        /// </summary>
        /// <param name="enabled">
        /// When enabled, users may attach images or PDFs in chat when the LLM supports multimodal input.
        /// </param>
        /// <param name="maxFilesPerConversation">
        /// Maximum number of files that can be uploaded per conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileInputConfigWorkflowOverride(
            bool? enabled,
            int? maxFilesPerConversation)
        {
            this.Enabled = enabled;
            this.MaxFilesPerConversation = maxFilesPerConversation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileInputConfigWorkflowOverride" /> class.
        /// </summary>
        public FileInputConfigWorkflowOverride()
        {
        }

    }
}