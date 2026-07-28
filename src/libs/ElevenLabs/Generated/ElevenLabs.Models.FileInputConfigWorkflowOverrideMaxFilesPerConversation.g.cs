
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Total files a user can upload in one conversation. Uploads are billed per file. Use -1 for no limit, or a value &gt;= max_files_in_memory.
    /// </summary>
    public sealed partial class FileInputConfigWorkflowOverrideMaxFilesPerConversation
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}